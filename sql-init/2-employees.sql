insert into employees (id, name, employeetype , telephone , address , employmentdate )
values (
  uuid_generate_v4(),
  'Carlos',
  (select id from employeetypes where name = 'Manager'),
  '321312',
  'adddresssssss',
  now()
);
