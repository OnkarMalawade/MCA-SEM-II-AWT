# Session Management:
> 1. Need for Session Management <br/>

> 2. Levels of State Management:<p> <ul>
<li>Control</li> 
<li>Variable or Object Level</li>
<li>Single or Multiple page level</li>
<li>User Level</li>
<li>Application Level</li>
<li>Application to Application Level </li>
</ul>
</p> 
<br/>

> 3. Client Side Session Management: <br/>
> Hidden Field: it is best to store only small amounts of frequently changed data<br/>
> Cookies: Store data in client data, simplicity, Data Persistance, Wide Support, No Server resource Required, limited data and limited cookie, url with data<br/>
> Control State: To cache the data for the store data, essential for the private data show , it is used to store small amount  of critical data storing, Complex technique,Programming is required.<br/>
> Query Strings: A Query String is used to pass the values or information form one page to another page, Widespread Support, Simple Implimentation, Potential Security Risk<br/>
> View State: Save the data for the user. it store the value with help of hashtable, cannot store the larger values<br/>

> 4. Server Side Session Management <br/>
> Session: InProc : Inside Memory Object, State Server: we have to provide service by using IP address : Aspnet_state.exe, SQLServer : Database stored data, Custom : Custom Provider<br/>
> <img src="https://www.codeproject.com/KB/session/ExploringSession/explor5.jpg"/><br/>
> Application<br/>
> Profile Properties<br/>
> Cache<br/>
> Context.Items<br/>

> 5. Session Management: In Process, Out Of Process: Mode
