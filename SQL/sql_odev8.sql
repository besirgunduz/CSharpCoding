--test veritabanınızda employee isimli sütun bilgileri 
--id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
create table employee
(
	id serial primary key,
	name varchar(50) not null,
	birthday date,
	email varchar(100)
);

--Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
insert into employee (name, birthday, email) values ('Franciskus', '1995-06-07', 'fmerry0@time.com');
insert into employee (name, birthday, email) values ('Prinz', '2012-10-28', 'pyerrell1@usgs.gov');
insert into employee (name, birthday, email) values ('Darill', '2005-06-23', 'dmolineux2@ow.ly');
insert into employee (name, birthday, email) values ('Paulie', '1999-08-05', 'pbarnsdale3@sohu.com');
insert into employee (name, birthday, email) values ('Claudina', '2001-08-15', 'csimmell4@accuweather.com');
insert into employee (name, birthday, email) values ('Brita', '2010-08-24', 'boakly5@liveinternet.ru');
insert into employee (name, birthday, email) values ('Nicola', '2001-01-06', 'nordish6@hhs.gov');
insert into employee (name, birthday, email) values ('Vania', '2001-01-08', 'vfancy7@freewebs.com');
insert into employee (name, birthday, email) values ('Earlie', '2006-09-07', 'esealand8@desdev.cn');
insert into employee (name, birthday, email) values ('Cherie', '1998-02-11', 'chartridge9@buzzfeed.com');
insert into employee (name, birthday, email) values ('Helenka', '2014-11-23', 'hclowleya@odnoklassniki.ru');
insert into employee (name, birthday, email) values ('Danice', '2011-05-23', 'dbirkenshawb@mail.ru');
insert into employee (name, birthday, email) values ('Pacorro', '2000-02-21', 'ptoonec@joomla.org');
insert into employee (name, birthday, email) values ('Dorella', '2013-04-08', 'dusmard@themeforest.net');
insert into employee (name, birthday, email) values ('Jessie', '1999-05-02', 'jvaughne@artisteer.com');
insert into employee (name, birthday, email) values ('Lyon', '1999-11-03', 'lhaylettf@deviantart.com');
insert into employee (name, birthday, email) values ('Abbie', '1993-09-18', 'apettingerg@reverbnation.com');
insert into employee (name, birthday, email) values ('Farris', '2012-07-31', 'fsussansh@ifeng.com');
insert into employee (name, birthday, email) values ('Kassey', '2009-05-05', 'kbirtwelli@sakura.ne.jp');
insert into employee (name, birthday, email) values ('Pat', '2007-03-27', 'pstandrinj@sourceforge.net');
insert into employee (name, birthday, email) values ('Kingsly', '2009-01-28', 'kspekek@arstechnica.com');
insert into employee (name, birthday, email) values ('Katina', '2004-01-08', 'kcockerelll@psu.edu');
insert into employee (name, birthday, email) values ('Carlyle', '2001-03-07', 'cdaceym@unicef.org');
insert into employee (name, birthday, email) values ('Hermine', '2000-08-17', 'hraitn@nyu.edu');
insert into employee (name, birthday, email) values ('Wendall', '2021-03-02', 'wlosanoo@cbslocal.com');
insert into employee (name, birthday, email) values ('Elaine', '2012-10-26', 'epecholdp@stanford.edu');
insert into employee (name, birthday, email) values ('Denney', '2004-08-22', 'dreadingq@mac.com');
insert into employee (name, birthday, email) values ('Helen', '2018-03-17', 'hvanarsdaler@amazonaws.com');
insert into employee (name, birthday, email) values ('Giacomo', '1999-03-27', 'gkirmonds@amazon.co.jp');
insert into employee (name, birthday, email) values ('Opaline', '1996-06-25', 'ocoetzeet@scribd.com');
insert into employee (name, birthday, email) values ('Ruthie', '2006-01-08', 'rwissbeyu@sina.com.cn');
insert into employee (name, birthday, email) values ('Jaquith', '1994-08-20', 'jbirtonshawv@ucoz.ru');
insert into employee (name, birthday, email) values ('Lynnell', '2001-02-25', 'lrhydderchw@ed.gov');
insert into employee (name, birthday, email) values ('Vasily', '2003-08-27', 'vtoraldx@hugedomains.com');
insert into employee (name, birthday, email) values ('Carlyn', '2014-08-14', 'cninnoliy@smugmug.com');
insert into employee (name, birthday, email) values ('Janet', '1997-10-03', 'jmcelhinneyz@deliciousdays.com');
insert into employee (name, birthday, email) values ('Durward', '2004-11-21', 'drossbrooke10@webnode.com');
insert into employee (name, birthday, email) values ('Matti', '2009-04-06', 'mgawn11@myspace.com');
insert into employee (name, birthday, email) values ('Celle', '2005-03-28', 'cdyment12@w3.org');
insert into employee (name, birthday, email) values ('Florian', '2015-09-20', 'fcullinan13@wikia.com');
insert into employee (name, birthday, email) values ('Jonell', '2009-02-12', 'jwathey14@ebay.co.uk');
insert into employee (name, birthday, email) values ('Fancy', '2004-03-09', 'fakers15@soundcloud.com');
insert into employee (name, birthday, email) values ('Emmalynne', '2014-10-30', 'egollin16@marriott.com');
insert into employee (name, birthday, email) values ('Herrick', '2000-08-05', 'hodyvoy17@canalblog.com');
insert into employee (name, birthday, email) values ('Chev', '2011-02-24', 'cmitchinson18@accuweather.com');
insert into employee (name, birthday, email) values ('Lisa', '2019-05-14', 'lbarents19@va.gov');
insert into employee (name, birthday, email) values ('Adrian', '1998-03-26', 'abulfit1a@house.gov');
insert into employee (name, birthday, email) values ('Elinore', '2021-02-16', 'esutterby1b@ycombinator.com');
insert into employee (name, birthday, email) values ('Benjamin', '1996-12-06', 'boen1c@mapquest.com');
insert into employee (name, birthday, email) values ('Dimitri', '2006-02-20', 'deverton1d@facebook.com');

--Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
update employee
set name='Beşir',birthday='1993-10-10',email='besirgunduz1993@gmail.com'
where id =1;

update employee
set birthday='1994-10-10',email='besirgunduz93@gmail.com'
where name='Beşir';

update employee
set name='beşir',email='besirgunduz1993@gmail.com'
where birthday='1994-10-10';

update employee
set name='Mehmet',birthday='1995-10-10',email='mehmet@gmail.com'
where id =2;

update employee
set name='memo',email='mehmet2@gmail.com'
where birthday='1995-10-10';

--Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
delete from employee
where name='Darill';

delete from employee
where birthday='2005-06-23';

delete from employee
where email='pbarnsdale3@sohu.com';

delete from employee
where id=2;

delete from employee
where id=3;


