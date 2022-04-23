**Correct:**
```
POST http://localhost/WebApiSamples/Person HTTP/1.1
Content-Type: application/json

{"City": "City not empty", "Phone": "+7(123)456 78 90", "Email": "kuzmin.nick@rambler.ru", "FullName": "Кузьмин Никита" }
```
---------------------------------------------------
**Incorrect (Required field is missing):**
```
POST http://localhost/WebApiSamples/Person HTTP/1.1
Content-Type: application/json

{"Phone": "+7(123)456 78 90", "Email": "kuzmin.nick@rambler.ru", "FullName": "Кузьмин Никита" }
```

```
POST http://localhost/WebApiSamples/Person HTTP/1.1
Content-Type: application/json

{"City": "City not empty", "Email": "kuzmin.nick@rambler.ru", "FullName": "Кузьмин Никита" }
```

```
POST http://localhost/WebApiSamples/Person HTTP/1.1
Content-Type: application/json

{"City": "City not empty", "Phone": "+7(123)456 78 90", "FullName": "Кузьмин Никита" }
```

```
POST http://localhost/WebApiSamples/Person HTTP/1.1
Content-Type: application/json

{"City": "City not empty", "Phone": "+7(123)456 78 90", "Email": "kuzmin.nick@rambler.ru" }
```
---------------------------------------------------
**Incorrect (email has incorrect format):**
```
POST http://localhost/WebApiSamples/Person HTTP/1.1
Content-Type: application/json

{"City": "City not empty", "Phone": "+7(123)456 78 90", "Email": "kuzmin.nick@rambler.ru@ru", "FullName": "Кузьмин Никита" }
```

```
POST http://localhost/WebApiSamples/Person HTTP/1.1
Content-Type: application/json

{"City": "City not empty", "Phone": "+7(123)456 78 90", "Email": "kuzmin.nick", "FullName": "Кузьмин Никита" }
```
---------------------------------------------------
