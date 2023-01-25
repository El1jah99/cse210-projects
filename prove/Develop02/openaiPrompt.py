import openai
import time

# Use the API key from your OpenAI account
openai.api_key = "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"

def main():


    response = getPrompt()
    

    # count = 0

    # if response[-1] != "." or response[-1] != "?" or response[-1] != "!" or response[-1] != ":":
        
    #     time.sleep(5)

    #     getPrompt()

    # else:

    generated_prompt = response.rstrip()

      # Print the generated prompt
    # print(generated_prompt)

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