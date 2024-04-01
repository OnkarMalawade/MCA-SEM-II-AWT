# Language Integrated Query(LINQ)
<br/>

## Part of Practical 3

<hr/>

### Introduced in VS 2008
> LINQ offers common Syntax for the Querying any type of Data Source.

### Types of LINQ:
> LINQ to Object<br/>
> LINQ to XML<br/>
> LINQ to DataSet<br/>
> LINQ to SQL<br/>
> LINQ to Entities<br/>
> There are other Some of the LINQ are PLINQ(MS Parralel LINQ).
<center>
<img src="https://media.geeksforgeeks.org/wp-content/uploads/20190504200533/Untitled-Diagram24.jpg" alt="LINQ Architecture" />
</center>

### Lambda Method:
> Syntax : <br/>

```
string [] words = {'hello' , 'friends', 'Chai', 'Pillo'};
var longWords = words.Where(w => words.Length > 5);
foreach(var w in longWords){
  Console.WriteLine(w);
}
  Console.ReadLine();
```

### Query Method:
> Syntax : <br/>

``` 
 string [] w = {'hello' , 'friends', 'Chai', 'Pillo'};
 var longWords = from words in w where words.Length <= 5 select words;
 foreach(var w in longWords){
  Console.WriteLine(w);
}
  Console.ReadLine();
```

### Steps :
> 1. Specify Source Creation <br/>
> 2. Define Query Expression defination <br/>
> 3. Execute Query(Done using for each loop)<br/>
