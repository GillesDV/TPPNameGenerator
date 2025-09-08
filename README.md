
# TwitchPlaysPokemon Name Generator

**TLDR:** A program that generates nonsensical nicknames using random inputs on a virtual keyboard. 


## Background
**Twitch.tv** is a live streaming platform, primarily focused on gaming, where viewers can watch, chat, and interact with streamers in real time.

**Twitch Plays Pokémon** was a famous social experiment (2014) where thousands of Twitch users collectively played a Pokémon game by typing commands (like `up`, `down`, `a`, `b`) into the chat. The stream interpreted those commands and sent them to the game, creating chaotic but collaborative gameplay. 
This resulted in not only chaotic movements, but also silly, chaotic names such as `AA-j` or `aaabaaajss`. 

This program recreates some of that magic, generating random inputs that correspond to 
- Moving around on a keyboard for the currently selected letter (up, down, left, right) 
- A = Select the current letter
- B = Remove the current letter
- Start = Finalize the selection process and build the selection of inputs into a name)
- Select = Swap virtual keyboards 

The process of generating random inputs ends when either
- 10 characters have been selected 
    - keep in mind characters can be removed. 
- Start has been selected as input

## 🚀 Features
- Program will return a nickname for a pokemon, using random inputs as if a user was typing on a keyboard. 

## 🚀 Extra feature ideas
- Add an API interface, on top of the Console. Re-using the same BusinessLogic of course. 
- ChatGPT / AI integration, which would give a 'readable' nickname to the possible nonsense that random input can produce. eg: `AAJSSXQ` could be named `Ajax`

## 🛠️ Requirements
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## 🔧 Setup & Run
```bash
# Clone the repo
git clone https://github.com/GillesDV/TPPNameGenerator.git
cd project-name

# Build
dotnet build

# Run
dotnet run