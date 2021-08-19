--city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country)
--isimlerini birlikte görebileceğimiz LEFT JOIN sorgusunu yazınız.
select ci.city,co.country from city ci
left join country co on ci.country_id=co.country_id;

--customer tablosu ile payment tablosunda bulunan 
--payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz RIGHT JOIN sorgusunu yazınız.
select p.payment_id,c.first_name,c.last_name from customer as c
right join payment as p on c.customer_id=p.customer_id;

----customer tablosu ile rental tablosunda bulunan
--rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz FULL JOIN sorgusunu yazınız.
select r.rental_id,c.first_name,c.last_name from customer c
full join rental r on c.customer_id=r.customer_id;



