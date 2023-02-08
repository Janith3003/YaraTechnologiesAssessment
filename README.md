<div align="center">
 <img src="https://cdn.cdnlogo.com/logos/c/27/c.svg" width=60>
 <h1> Assessment of Yara Technologies </h1>
</div>
<br><br>

## How to customize Connection String in C# MySql [ >> line 18 ](/YaraTechnologiesAssesment/DBData.cs)

 * no need to connect the database to VS
 ```c#
MySqlConnection con;
con = new MySqlConnection(
                          " server=localhost; " + 
                          " uid=root; " +
                          " password=; " +
                          " database=yaratechnologiesassessment "
                          ); 
```
 - ` server ` : your current local machine (always localhost)
 - ` uid ` : username of your database account
 - ` password ` : password of your database account
 - ` database ` : databse name you created
