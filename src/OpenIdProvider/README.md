# Tích hợp single sign-on với Everlearn

## OP provider

Everlearn hỗ trợ đăng nhập bằng OAuth. Sample này sử dụng .NET Core và [IdentityServer4](https://github.com/IdentityServer/IdentityServer4) để khởi tạo một OAuth provider đơn giản.

Để cho phép Everlearn sử dụng identity, OP cần có 1 client với thông số:

```
client_id: <tùy chọn>
client_secret: <tùy chọn>
redirect_uri: https://id.everlearn.vn/signin-oauth/tenant
```  

(Tham khảo [IdServerConfig.cs](Data/IdServerConfig.cs))

## Everlearn

Đường dẫn đăng nhập SSO Everlearn

```
- https://id.everlearn.vn/sso?tenant=<tenant_id>
```

Khi người dùng truy cập đường dẫn trên, Everlearn sẽ chuyển hướng người dùng đến trang login của OP, ngưởi dùng sau khi đăng nhập ở đây sẽ được chuyển hướng về everlearn với trạng thái đãng nh
