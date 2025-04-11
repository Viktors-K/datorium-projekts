// Use DBML to define your database structure
// Docs: https://dbml.dbdiagram.io/docs

// Izveidots mājaslapā https://dbdiagram.io/d

Table users {
  id integer [primary key, increment]
  username varchar [unique, not null]
  email varchar [unique, not null]
  password_hash varchar [not null]
  admin boolean [not null, default: 0]
  profile_data json
}

Table items {
  id integer [primary key, increment]
  type varchar [not null]
  status text [not null]
  details text
}

Table handouts {
  id integer [primary key, increment]
  item_id integer [not null]
  username varchar [not null]
  issued_at timestamp [not null]
  due_at timestamp [not null]
  status text [not null]
}

Table reservations {
  id integer [primary key, increment]
  item_id integer [not null]
  username varchar [not null]
  reserved_from timestamp [not null]
  reserved_until timestamp [not null]
  status varchar [not null]
}

Ref: handouts.item_id > items.id
Ref: handouts.username > users.username

Ref: reservations.item_id > items.id
Ref: reservations.username > users.username
