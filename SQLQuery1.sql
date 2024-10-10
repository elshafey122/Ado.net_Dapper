create database DigitalCurrency;
go 

use DigitalCurrency;
go

create table wallets
(
  Id int identity(1,1) primary key,
  Holder varchar(20) not null,
  Balance decimal (18,0) not null
);
go

insert into wallets (Holder,Balance)
values('ahmed',10000),('reem',5000);
go

create procedure AddWallet
@Holder varchar(20),
@Balance decimal (18,0)
as 
begin
insert into wallets (Holder,Balance)
values (@Holder,@Balance)
end

go


create procedure GetAllWallets
as 
begin
select * from wallets
end

go



