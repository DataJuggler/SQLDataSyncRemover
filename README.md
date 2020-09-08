# SQLDataSyncRemover
This simple utility allows you to browse for a SQL text file, and then click the Remove Data Sync button, and any block of SQL that contains the word DataSync is not copied.

# The Problem
One of clients uses SQL Data Sync to copy the data from SQL Server on a VM to Azure SQL for backup that is not on the VM itself.

Whenever I script the database from the Test Server to work on a problem on my machine, I have to manually remove all the Data Sync tables and procedures that get copied, and it is more tables and procedures than the database has without DataSync. It was a pain in the butt to do this.

I wrote this program in about 15 minutes, here are the steps to build this if anyone is curious:

1. Add a Nuget reference to DataJugger.Win.Controls, then drag a LabelTextBrowserControl on the form (from the DataJuggler Toolbox section. Rebuild if you don't see it).

2. To parse the files, I used DataJuggler.Core.UltimateHelper (added when you add the reference in step 1). This library contains a TextLine object in DataJuggler.Core.UltimateHelper.Objects, and WordParser to parser.

     // get the text
     string filePath = SQLFileControl.Text;
     
      // get the text lines
      List<TextLine> lines = WordParser.GetTextLines(fileText);
  
  3. I created a class called a SQLBlock. This class contains a list of TextLine objects. I then iterate the text lines from the document, and if line.Text equals GO, I add the old SQL Block to my collection of SQL Blocks.
  
  4. I added a read only property to class SQLBlock called ContainsDataSync. This property iteraets the lines in its own collection of lines, and if any of the lines contain the text Data Sync, then this is return false, else it will return true if none are found.
  
  5. Next I iterate the collection of SQL Blocks and I created a StringBuilder to rebuild one long string, and I put back the GO and new line characters for each line.
  
  I have not tested this extensively, but my database is in sync with the original database, just without the DataSync tables and stored procedures.
  
  Not sure if anyone else is in my shoes where one server has the DataSync and another doesn't, but this tool works well for this scenario.
