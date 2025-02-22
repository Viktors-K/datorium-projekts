// Use DBML to define your database structure
// Docs: https://dbml.dbdiagram.io/docs

// Izveidots mājaslapā https://dbdiagram.io/d

Table users {
  id integer [primary key, increment]
  username varchar [unique, not null]
  name varchar [not null]
  surname varchar [not null]
  class varchar [not null]
}

Table items {
  id integer [primary key, increment]
  type varchar [not null]
  description text
}

Table handouts {
  id integer [primary key, increment]
  item_id integer [not null]
  username varchar [not null]
  issue_time timestamp [not null]
  due_time timestamp [not null]
  returned_time timestamp
}

Table reservations {
  id integer [primary key, increment]
  item_id integer [not null]
  username varchar [not null]
  reserved_from timestamp [not null]
  reserved_until timestamp [not null]
  status varchar [not null]
}

Ref: reservations.item_id > items.id // many-to-one  
Ref: reservations.username > users.username // many-to-one  

Ref: handouts.item_id > items.id // many-to-one  
Ref: handouts.username > users.username // many-to-one  