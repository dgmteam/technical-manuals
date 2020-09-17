# Tích hợp single sign-on với Everlearn

Everlearn hỗ trợ đăng nhập bằng OAuth. Sample này sử dụng .NET Core và [IdentityServer4](https://github.com/IdentityServer/IdentityServer4) để khởi tạo một OAuth provider đơn giản.

Để cho phép Everlearn sử dụng identity, OP cần có 1 client với thông số:

```
client_id: <tùy chọn>
client_secret: <tùy chọn>
redirect_uri: https://id.everlearn.vn/signin-oauth/tenant
```  

(Tham khảo [IdServerConfig.cs](Data/IdServerConfig.cs))