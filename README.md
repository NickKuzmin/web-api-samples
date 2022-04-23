**Corect:**
```
POST http://localhost/WebApiSamples/Person HTTP/1.1
Content-Type: application/json

{"City": "City not empty", "Phone": "+7(123)456 78 90", "Email": "kuzmin.nick@rambler.ru"}
```
---------------------------------------------------
**Incorrect (FullName is missing):**
```
POST http://localhost/WebApiSamples/Person HTTP/1.1
Content-Type: application/json

{"City": "City", "Phone": "Phone", "Email":"Email"}
```
---------------------------------------------------
