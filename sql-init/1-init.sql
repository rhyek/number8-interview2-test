begin;
CREATE extension if not exists "uuid-ossp";

create table employeetypes (
	id uuid primary key,
	name varchar(50) not null unique,
	salary decimal(10,2) not null
);

create table employees (
	id uuid primary key,
	name varchar(50) not null unique,
	employeetype uuid not null references employeetypes(id),
	telephone varchar(20) not null,
	address varchar(200) not null,
	employmentdate timestamptz not null
);

create table shops (
	id uuid primary key,
	name varchar(50) not null unique,
	telephone varchar(20) not null,
	address varchar(200) not null
);

create table employee_shop_attendance (
	id uuid primary key,
	employee_id uuid not null references employees(id),
	shop_id uuid not null references shops(id),
	attendancedate timestamptz not null
);

insert into employeetypes (id, name, salary)
values
	(uuid_generate_v4(), 'Manager', 1000),
	(uuid_generate_v4(), 'Accountant', 600),
	(uuid_generate_v4(), 'Clerk', 500);

commit;

