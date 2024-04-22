from google_auth_oauthlib.flow import InstalledAppFlow
from googleapiclient.discovery import build
import json

person_info = {}
# Path to  credentials file
credentials_path = 'client_secret_731298178693-tb15106p8tbprosrbql3t4fqa0q68st0.apps.googleusercontent.com.json'
#
# Scope for reading form responses
scopes = ['https://www.googleapis.com/auth/forms.responses.readonly']

# Authenticate and build the service
flow = InstalledAppFlow.from_client_secrets_file(credentials_path, scopes)
creds = flow.run_local_server(port=0)
service = build('forms', 'v1', credentials=creds)

# ID of  form
form_id = '1JeuzJUOSR4Po4wjeKxVZ3EgqdTEC4sEZyMFN_kvYVE4'

# Fetch form responses
responses = service.forms().responses().list(formId=form_id).execute()

json_object = json.dumps(responses, indent=4)
response_dict = json.loads(json_object)
final_response = response_dict["responses"][0]
name = final_response['answers']['7097c5ba']['textAnswers']['answers'][0]['value']
budget = final_response['answers']['0d9fc917']['textAnswers']['answers'][0]['value']
password = final_response['answers']['6df45611']['textAnswers']['answers'][0]['value']


person_info["name"] = name
person_info["budget"] = budget
person_info["password"] = password

print(person_info)

