HTML to PDF API
============

HTML to PDF is a simple tool for converting HTML to PDF. It returns the PDF file generated from the HTML.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [HTML to PDF API](https://apiverve.com/marketplace/api/htmltopdf)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.HTMLtoPDF
```

Using the Package Manager:
```
nuget install APIVerve.API.HTMLtoPDF
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.HTMLtoPDF
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.HTMLtoPDF".
5. Click on the APIVerve.API.HTMLtoPDF package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the htmltopdf API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The HTML to PDF API documentation is found here: [https://docs.apiverve.com/api/htmltopdf](https://docs.apiverve.com/api/htmltopdf).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
HTML to PDF API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new HTMLtoPDFAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new HTMLtoPDFQueryOptions {
  marginTop = 0.4,
  marginBottom = 0.4,
  marginLeft = 0.4,
  marginRight = 0.4,
  landscape = false,
  html = "<!doctype html> <html>  <head> <title>This is the title of the webpage!</title> </head> <body> <p>This is an example paragraph. Anything in the <strong>body</strong> tag will appear on the page, just like this <strong>p</strong> tag and its contents.</p> </body> </html>"
}
;
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "marginLeft": "0.4in",
    "marginRight": "0.4in",
    "marginTop": "0.4in",
    "marginBottom": "0.4in",
    "landscape": false,
    "pdfName": "0edcc51a-3c6b-4eac-8761-b41a4919f7f4.pdf",
    "expires": 1725355755108,
    "downloadURL": "https://storage.googleapis.com/apiverve-helpers.appspot.com/htmltopdf/0edcc51a-3c6b-4eac-8761-b41a4919f7f4.pdf?GoogleAccessId=1089020767582-compute%40developer.gserviceaccount.com&Expires=1725355755&Signature=BBWhYzDCBXS%2FpRQrKgIAmt3%2F7gwO599vyNGOTXBdUtbONGpV7FNldgJnoIK6h3pip3%2FCDDaNoeuXJbC1wZ2ZamJ4qYc0S2TqivAN3wAMoPnfeKpenWEWLqvROHQJdCSwil43u7oB1FUCDRfzxGpPmgjGJBXgmBNwO1k%2BTNNEYxl2M3QHlAT%2BbVlGLlrRHWaRN6WWPKYhEMFQNcNA1djGTfBRReAbr%2FpX44QG9FnJFZ3wQg%2BS4Z8jTpnzXXVJBcIHJ0tVhzsj6HpLQmq43BRYsI7wmMeKNT5ooyYjDQGt%2BShKN4HNSddMKDxElpUSBXFhARoWQm0S8JJfX0aCzubttw%3D%3D"
  },
  "code": 200
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.