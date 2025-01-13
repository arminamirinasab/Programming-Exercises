# Application API
This API provides a list of App Store applications along with their links and screenshots. Below, you can find more information on how to use this API and the structure of the output data.

Output Data Structure
The output of this API is in JSON format and consists of a list of applications. Each application has the following information:

<code>
id: Unique identifier of the application
name: Name of the application
link: Link to download or access the application
image: Link to the application's screenshot (Local)
</code>

<br>
Example Output:

<pre>
[
    {
        "id": 1,
        "name": "Whatsapp",
        "image": "whatsapp.webp",
        "link": "https://apps.apple.com/us/app/whatsapp-messenger/id310633997"
    },
    {
        "id": 2,
        "name": "Blue Sky",
        "image": "bluesky.webp",
        "link": "https://apps.apple.com/us/app/bluesky-social/id6444370199"
    },
    {
        "id": 3,
        "name": "Telegram",
        "image": "telegram.webp",
        "link": "https://apps.apple.com/us/app/telegram-messenger/id686449807"
    },
    {
        "id": 4,
        "name": "Apple Podcast",
        "image": "podcast.webp",
        "link": "https://apps.apple.com/us/app/apple-podcasts/id525463029"
    },
    {
        "id": 5,
        "name": "Radio Javan",
        "image": "rj.webp",
        "link": "https://apps.apple.com/us/app/radio-javan/id286225933"
    },
    {
        "id": 6,
        "name": "Brave Browser",
        "image": "brave.webp",
        "link": "https://apps.apple.com/us/app/brave-browser-search-engine/id1052879175"
    },
    {
        "id": 7,
        "name": "Facebook Messanger",
        "image": "messanger.webp",
        "link": "https://apps.apple.com/us/app/messenger/id454638411"
    },
    {
        "id": 8,
        "name": "iMessage",
        "image": "messages.webp",
        "link": "https://apps.apple.com/us/app/messages/id1146560473"
    },
    {
        "id": 9,
        "name": "Mastadon",
        "image": "mastadon.webp",
        "link": "https://apps.apple.com/us/app/mastodon/id1571998974"
    }
]
</pre>
## Using the API
To use this API, you can send a GET request to the API address to receive the list of applications.
Start server with:
<pre>npm start</pre>

<pre>API Address: http://localhost:3333/images/
Method: GET
Request Parameters: None
</pre>
