
'''
Created by Mahdi Mashayekhi
Email : MahdiMashayekhi.ai@gmail.com
Github : https://github.com/MahdiMashayekhi-AI
Site : https://mahdimashayekhi.ir
YouTube : https://youtube.com/@MahdiMashayekhi
Twitter : https://twitter.com/Mashayekhi_AI
LinkedIn : https://www.linkedin.com/in/mahdimashayekhi/
'''

# Go to this site:
# www.textlocal.in
# For out of Iran! :)
# You can use Iranians site

import requests
url = 'https://api.textlocal.in/'
params = {'username':'YUOR_USERNAME',
          'apiKey':'YOUR_API_KEY',
}


def check_balance(url):
    url = url+'balance'
    response = requests.get(url,params=params)
    return response.json()
def send_sms(url,params):
    url=url+'send'
    #Phone numbers inside braces {} in commas
    numbers={'09xxxx'}
    message = {'Hi, This is a Sample message'}
    params['numbers'] = numbers
    params['message'] = message
    response = requests.post(url,params=params)
    return response.json()

def inbox(url):
    url = url+'get_inboxes'
    response = requests.get(url,params=params)
    return response.json()