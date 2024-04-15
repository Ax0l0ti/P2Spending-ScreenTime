from google_auth_oauthlib.flow import InstalledAppFlow
from googleapiclient.discovery import build
import json


print("Started")
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
form_id = '1kxa76M58gYKgVskbWPYNe9VObZAW3DvOaQG-0AidYno'

# Fetch form responses
responses = service.forms().responses().list(formId=form_id).execute()

json_object = json.dumps(responses, indent=4)

print(json_object)

