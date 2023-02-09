create table product (
  product_id INT PRIMARY KEY,
  name VARCHAR(255)
);
create table category (
  category_id INT PRIMARY KEY,
  name VARCHAR(255)
);
create table product_category (
  product_id INT,
  category_id INT,
  foreign key (product_id) references product (product_id),
  foreign key (category_id) references category (category_id)
);

select product.name,category.name from product
left join product_category as pc
on product.product_id = pc.product_id
left join category on pc.category_id = category.category_id