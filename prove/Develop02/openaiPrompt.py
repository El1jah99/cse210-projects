import openai

# Use the API key from your OpenAI account
openai.api_key = "YOUR API KEY - Get one for free at https://platform.openai.com/account/api-keys"

def main():


    response = getPrompt()
    
    generated_prompt = response.rstrip()


    # Write the prompt to the "JournalPrompts.txt" file

    with open("JournalPrompts.txt", "w") as f:
        
        f.write(generated_prompt)
    
    with open('JournalPrompts.txt', 'r') as file:
    
        lines = file.readlines()

    with open('JournalPrompts.txt', 'w') as file:

        file.writelines(lines[2:])
    
    return generated_prompt


def getPrompt():

    # Define the prompt for GPT-3
    prompt = (f"Give me a short (around 20-60 characters), fun, interesting, deep, and reflective journal prompt. Do not include numbers. No more than one question.")

    # Use GPT-3 to generate a response to the prompt
    response = openai.Completion.create(
        engine="text-davinci-002",
        prompt=prompt
    )

    return response["choices"][0]["text"]

main()
