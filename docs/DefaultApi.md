# Org.OpenAPITools.Api.DefaultApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**JuguguFastGetNFTPost**](DefaultApi.md#jugugufastgetnftpost) | **POST** /Jugugu_FastGetNFT | 3.jugugu获取小红花POAP
[**JuguguFastLoginPost**](DefaultApi.md#jugugufastloginpost) | **POST** /Jugugu_FastLogin | 2.注册jugugu登录
[**JuguguFastRegPost**](DefaultApi.md#jugugufastregpost) | **POST** /Jugugu_FastReg | 1.注册jugugu
[**JuguguFastSignTxPost**](DefaultApi.md#jugugufastsigntxpost) | **POST** /Jugugu_FastSignTx | 4.使用jugugu进行交易签名



## JuguguFastGetNFTPost

> InlineResponse2001 JuguguFastGetNFTPost (InlineObject2 inlineObject2 = null)

3.jugugu获取小红花POAP

使用项目方自己账户体系的OpenID注册并绑定jugugu账号，项目方接入jugugu的Account和Secret以及用户登录后的登录令牌token，等参数请求进行小红花POAP领取。

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class JuguguFastGetNFTPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var inlineObject2 = new InlineObject2(); // InlineObject2 |  (optional) 

            try
            {
                // 3.jugugu获取小红花POAP
                InlineResponse2001 result = apiInstance.JuguguFastGetNFTPost(inlineObject2);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.JuguguFastGetNFTPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inlineObject2** | [**InlineObject2**](InlineObject2.md)|  | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功 |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## JuguguFastLoginPost

> InlineResponse200 JuguguFastLoginPost (InlineObject inlineObject = null)

2.注册jugugu登录

使用项目方自己账户体系OpenID,用户手机号，项目方接入jugugu的Account和Secret登录用户jugugu账户，获得登录token  该token用于后续函数调用

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class JuguguFastLoginPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var inlineObject = new InlineObject(); // InlineObject |  (optional) 

            try
            {
                // 2.注册jugugu登录
                InlineResponse200 result = apiInstance.JuguguFastLoginPost(inlineObject);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.JuguguFastLoginPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inlineObject** | [**InlineObject**](InlineObject.md)|  | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功 |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## JuguguFastRegPost

> InlineResponse200 JuguguFastRegPost (InlineObject1 inlineObject1 = null)

1.注册jugugu

使用项目方自己账户体系的OpenID注册并绑定jugugu账号，如果该手机已经注册jugugu则直接进行绑定OpenID。注册的用户返回短密钥，绑定的用户不返回短密钥，短密钥请务必加密存储，建议使用ECC256进行加密，加密解密密钥妥善保存，建议内存中存放

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class JuguguFastRegPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var inlineObject1 = new InlineObject1(); // InlineObject1 |  (optional) 

            try
            {
                // 1.注册jugugu
                InlineResponse200 result = apiInstance.JuguguFastRegPost(inlineObject1);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.JuguguFastRegPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inlineObject1** | [**InlineObject1**](InlineObject1.md)|  | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功 |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## JuguguFastSignTxPost

> Object JuguguFastSignTxPost (InlineObject3 inlineObject3 = null)

4.使用jugugu进行交易签名

使用项目方自己账户体系的OpenID，项目方接入jugugu的Account和Secret以及用户登录后的登录令牌token，等参数请求进行交易签名,返回签名后的交易数据rowData。详情见示例代码

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class JuguguFastSignTxPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var inlineObject3 = new InlineObject3(); // InlineObject3 |  (optional) 

            try
            {
                // 4.使用jugugu进行交易签名
                Object result = apiInstance.JuguguFastSignTxPost(inlineObject3);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.JuguguFastSignTxPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inlineObject3** | [**InlineObject3**](InlineObject3.md)|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功 |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

