# Products Api

- [Products](#Products)
  - [Create Product](#create-product)
    - [Create Product Request](#create-product-request)
    - [Create Product Response](#create-product-response)
  - [Get Product](#get-product)
    - [Get Product Request](#get-product-request)
    - [Get Product Response](#get-product-response)
  - [Update Product](#update-product)
    - [Update Product Request](#update-product-request)
    - [Update Product Response](#update-product-response)
  - [Delete Product](#delete-product)
    - [Delete Product Request](#delete-product-request)
    - [Delete Product Response](#delete-product-response)

## Create Product

### Create Product Request
```js
POST /products
```
```json
{
    "name": "Mouse",
    "description": "MX Master 3",
    "price": 189.50
}
```

### Create Product Response
```js
201 Created
```

```yml
Location: {{host}}/products/{{id}}
```

```json
{
    "id": "0000-0000-0000",
    "name": "Mouse",
    "description": "MX Master 3",
    "price": 189.50,
    "lastModified": "2023-08-06T12:00:00"
}
```

## Get Product

### Get Product Request
```js
GET /products/{{id}}
```

### Get Product Response
```js
200 OK
```

```json
{
    "id": "0000-0000-0000",
    "name": "Mouse",
    "description": "MX Master 3",
    "price": 189.50,
    "lastModified": "2023-08-06T12:00:00"
}
```

## Update Product

### Update Product Request
```js
PUT /products/{{id}}
```
```json
{
    "name": "Mouse",
    "description": "MX Master 3",
    "price": 189.50,
    "lastModified": "2023-08-06T12:00:00"
}
```

### Update Product Response
```js
204 No Content
```
or 
```js
201 Created
```

```yml
Location: {{host}}/products/{{id}}
```

## Delete Product

### Delete Product Request

```js
DELETE /products/{{id}}
```

### Delete IProducttem Response

```js
204 No Content
```