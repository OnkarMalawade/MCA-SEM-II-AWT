# Practical No.3
<br/>

## Data Bound Control (Grid View) 
<br/>

> <a href ="#">Data Source and Data Bound Control </a>
<br/>

> # ADO.net :Active X Data Objects is rich set of classes internet <br/>

> "using" is Keyword to import data <br/>

> 1. <b>Connected Archietecture:</b> Stay Connected while Accessing data with Connection string and retrive data from it. It contain SqlCommand,SqlDataReader,SqlConnection. SqlDataReader contain only single data and it Faster performance<br/>

> 2. <b>Disconnected Arichietecture:</b> When required you connected to the database. It contain temporary database work on the temporary db after it update to the Main db. It contain SqlConnection, DataSet, SqlDataAdapter,SqlCommandBuilder. DataSet is Slower and contain multiple type data<br/>

<img src="ADO.png">
</img>

class change with files name and connection file.

> SqlConnection: to connect with the DB using Open() method and Close().<br/>
> SqlConnection conn;<br/>
> conn.Open(); <br/>

> SqlCommand: Execute use various interactions based on the requirements <br/>
> 1. ExecuteScaler: Single cell operations to be perform by using it.(e.g. Select, Update, sum(), min(), max() )<br/>
> 2. ExecuteReader: When it executes returns an Instance of <b>DataReader</b> Class.<br/>
