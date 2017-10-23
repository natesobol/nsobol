// Programmer: Nate Sobol
// Last Modified: 11/16/16

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class textEditor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        downloadButton.Visible = false;
        // Initializes textbox
        ContentsTextBox.TextMode = TextBoxMode.MultiLine;
        //ContentsTextBox.ReadOnly = true;
        ContentsTextBox.Text = "";

    }

    protected void startButton_Click(object sender, EventArgs e)
    {
        // Server Path
        String path = Server.MapPath("~/Uploaded Files/");
        String fileExt = Path.GetExtension(FileUpload1.FileName);

        if (FileUpload1.HasFile)     // Detects if file uploader has file
        {
            if (fileExt == ".txt")
            {
                Label1.Text = "File Uploader has File!";

                // Attempts to save the file to the server
                try
                {
                    // Saves file to the server file path
                    FileUpload1.PostedFile.SaveAs(path + FileUpload1.FileName);
                    Label1.Text = "File uploaded!";
                }
                catch (Exception ex)
                {
                    Label1.Text = "File could not be uploaded." + ex + "\nPath:" + path;
                }

                try
                {

                    // Sets file attribute
                    File.SetAttributes(path + FileUpload1.FileName, FileAttributes.Normal);

                    // Uploads file to server and sends contents to a textbox
                    DisplayFileContents(FileUpload1.PostedFile);
                    downloadButton.Visible = true;
                    // Cleanup
                    
                }
                catch (Exception ex2)
                {
                    Label1.Text = "Issue reading file!: " + ex2 + "\nPath:" + path;
                }
            }
            else
                Label1.Text = "Not a txt file!";
        }
        else
            Label1.Text = "No file uploaded";
    }

    void DisplayFileContents(HttpPostedFile file){

        // Declarations
        System.IO.Stream inStream;
        Int32 fileLen;
        StringBuilder displayString = new StringBuilder();

        // Get the length of the file.
        fileLen = FileUpload1.PostedFile.ContentLength;
        byteLabel.Text = "The length of the file is " + fileLen.ToString() + " bytes.";

        // Create a byte array to hold the contents of the file.
        Byte[] Input = new Byte[fileLen];

        // Initialize the stream to read the uploaded file.
        inStream = FileUpload1.FileContent;

        // Read the file into the byte array.
        inStream.Read(Input, 0, fileLen);

        // Copy the byte array to a string.
        for (int i = 0; i < fileLen; i++){
            displayString.Append(Input[i].ToString());
        }

        
        

        // Converts file text from decimal to ascii
        ContentsTextBox.Text = System.Text.Encoding.ASCII.GetString(Input);
    }

    protected void downloadButton_Click(object sender, EventArgs e)
    {
        String path = Server.MapPath("~/Uploaded Files/");
        String ftpserver = "ftp://nsobol.com/httpdocs/Uploaded%20Files/test.txt";

        try
        {
            FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpserver));
            reqFTP.Credentials = new NetworkCredential("appuser", "Password");
            FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();

            Stream responseStream = response.GetResponseStream();
        }
        catch(Exception ex)
        {
            Label1.Text = "Couldn't download File: " + ex;
        }
        Label1.Text = "Downloaded File!";

        File.Delete(path + FileUpload1.FileName);

    }
}