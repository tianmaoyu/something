 :select into  临时表
 SELECT TOP 10 * into #temp FROM [Acadsoc.COM.CN].[dbo].[uc_UserComplain]
     
     select * from #temp


EXISTS、IN与JOIN，都可以用来实现形如“查询A表中在（或不在）B表中的记录”的查询逻辑。
在查询的两个表大小相当的情况下，3种查询方式的执行时间通常是：
EXISTS <= IN <= JOIN
NOT EXISTS <= NOT IN <= LEFT JOIN

 查询插入
```sql
 insert table1
   (feild,feild,feild,feild,feild,feild,feild) 
   select  value,valuevalue0,value,value,value,value 
   from tabel2 where
```
备份,zz 排序到最后，bak,标识备份
```sql
 SELECT  *  into zz_table_bak   FROM   table
 ```
 
