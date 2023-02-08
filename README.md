# Assessment of Yara Technologies

### How to customize Connection String in C# MySql [ >> line 18 ](/YaraTechnologiesAssesment/DBData.cs)

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
