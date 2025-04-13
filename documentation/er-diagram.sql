// Use DBML to define your database structure
// Docs: https://dbml.dbdiagram.io/docs

// Izveidots mājaslapā https://dbdiagram.io/d

Table users {
  id integer [primary key, increment]
  username text [unique, not null]
  email text [unique, not null]
  password_hash text [not null]
  admin boolean [not null, default: 0]
  profile_data json
}

Table items {
  id integer [primary key, increment]
  type text [not null]
  status text [not null]
  details text
}

Table handouts {
  id integer [primary key, increment]
  item_id integer [not null]
  username text [not null]
  issued_at datetime [not null]
  due_at datetime [not null]
  status text [not null]
}

Table reservations {
  id integer [primary key, increment]
  item_id integer [not null]
  username text [not null]
  reserved_from datetime [not null]
  reserved_until datetime [not null]
  status text [not null]
}

Ref: handouts.item_id > items.id
Ref: handouts.username > users.username

Ref: reservations.item_id > items.id
Ref: reservations.username > users.username