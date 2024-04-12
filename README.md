# Candidate Test
This repository is designed for a test aimed at prospective junior integration developers.

## Introduction
The task involves making a POST request to a specified URL using C#.NET. This test is intended to assess your ability to integrate with webhooks and handle web requests effectively.

## Test Details

### Task Description
You are required to send a POST request to the following URL:
https://flow.zoho.com/663067151/flow/webhook/incoming?zapikey=1001.72d0b18a4316a1acc8f0de7fa7dbdf74.4f792bf21ebf81a4d04112d94177a2a1&isdebug=false


#### Payload Format
The body of the POST request must be a JSON object formatted as follows:

```json
{
  "github_username": "Your Github username here",
  "short_greeting": "Short text here",
  "your_email": "Your Email",
  "random_number": {
    "number": 13,
    "reason": "Describe how and why you sent this random number"
  },
  "is_test": false
}
```
Note: Replace the placeholder values with your actual data. The random_number must be between 10 and 1000.

## Rules and Environment

#### Development Environment: 
The request must be made using C#.NET. Using the RestSharp NuGet package.

#### Testing: 
You may set is_test to true only once to test your submission.

#### Username Verification: 
Ensure that the github_username is accurately provided.

## How should I submit the code?

Simply create a fork of this repo and submit a pull request once done. Otherwise, you can use this Zoho WorkDrive collection URL to upload your files: https://workdrive.zohoexternal.com/collection/1vqmm1ae08d114b9e43d588e9c35899c056f5/external

Pick only one of these options. Make sure that if you are uploading the file through Zoho WorkDrive, give the same name to the folder as the value you provided for github_username in your valid JSON string.


