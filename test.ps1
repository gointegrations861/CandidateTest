# Define the URL and headers for the POST request
$url = "https://flow.zoho.com/663067151/flow/webhook/incoming?zapikey=1001.72d0b18a4316a1acc8f0de7fa7dbdf74.4f792bf21ebf81a4d04112d94177a2a1&isdebug=false"
$headers = @{
    "Content-Type" = "application/json"
}

# Create the JSON payload
$payload = @{
    github_username = "rebaccamin5"
    short_greeting = "Thank you for giving me this chance to test my ability"
    email = "minrebacca@gmail.com"
    name = "Rebacca Min"
    random_number = @{
        number = Get-Random -Minimum 10 -Maximum 1000
        reason = "The random number is generated for testing purposes"
    }
    is_test = false
}

# Convert the payload to JSON
$jsonPayload = $payload | ConvertTo-Json -Depth 5

# Use try-catch block to handle potential errors
try {
    # Send the POST request
    $response = Invoke-RestMethod -Uri $url -Method Post -Headers $headers -Body $jsonPayload
    # Output the response data
    Write-Output "Response received successfully:"
    Write-Output $response
}
catch {
    # Output error details
    Write-Output "Error occurred:"
    Write-Output $_.Exception.Message
    if ($_.Exception.Response) {
        $responseStream = $_.Exception.Response.GetResponseStream()
        $reader = New-Object System.IO.StreamReader($responseStream)
        $responseBody = $reader.ReadToEnd()
        Write-Output "Response content:"
        Write-Output $responseBody
    }
}