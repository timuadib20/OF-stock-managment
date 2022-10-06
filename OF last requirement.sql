CREATE proc uspSearchPurchaseItemByItemCodeAndDescribtion
@val nvarchar(500)
--@catagory nvarchar(400) output 
as
begin

select i.id ,ltrim(rtrim(i.itemcode)) as [Item Code],ltrim(rtrim(i.itemDescription)) as [Item Describtion],uom,unitPrice
from tblItem i
where ltrim(rtrim(i.itemDescription)) like '%'+@val+'%' or ltrim(rtrim(i.itemcode)) like '%'+@val+'%'
order by itemdescription
end

CREate proc uspSearchSupplierByname
@suppliername nvarchar(500)
as
begin
select tinNumber , suppliername as [Supplier Name],datename(month,date) as [Month],date as [Date] from tblSupplier
where suppliername like '%'+@suppliername +'%'
end
go

create proc uspSearchSupplierByTinnumber
@tinumber int
as
begin
select tinNumber , suppliername as [Supplier Name],datename(month,date) as [Month],date as [Date] from tblSupplier
where tinnumber = @tinumber 
end
go


select * from tblTranction

create table tblAudit(
Auditid uniqueidentifier rowguidcol not null
 constraint df_Audit_auditID default (newid())
  constraint df_Audit primary key  nonclustered (Auditid ),
Auditdate datetime not null,
sysuser varchar(50) not null,
tablename varchar(50) not null,
operation varchar(50) not null,
primarykey varchar(50) not null,
[column] varchar(50) not null,
oldvalue varchar(50)  null,
newvalue varchar(50)  null,
)

-----------
---login
create login [OFlogin] with password = '123', default_database = [Stock Managment]
create user [LocalUSER] for login [OFlogin]
exec sp_addrolemember 'db_owner','LocalUSER'
