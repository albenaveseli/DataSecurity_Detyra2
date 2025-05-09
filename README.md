#  Morse Code Encoder & Decoder – Console App in C#

This project was created as part of the **Data Security** class assignment (2025). It includes **encoding, decoding, and audio playback** of Morse Code using `Console.Beep()` in a console-based C# application.

---

##  **How to Run the Program**

1. Open the solution in **JetBrains Rider**, **Visual Studio**, or any other C# IDE.
2. Run the program.
3. Follow the instructions in the console:

   -  **Enter a message to encode** – type a word or sentence.
   -  The app encodes it into **Morse code** and displays the result.
   -  Then, it **plays the Morse code** using beeps (`Console.Beep()`).
   -  Next, you can **enter Morse code** manually to decode.
   -  The decoded text will be shown.

---
## ⚙️ **Technical Implementation Details**

###  **Project Structure**

- `Program.cs` – Entry point of the application. Manages the console UI and user choices (encode, decode, exit).
- `MorseEncoder.cs` – Encodes plain text into Morse Code using the dictionary defined in `MorseMap.cs`.
- `MorseDecoder.cs` – Decodes Morse Code into readable text by reversing the dictionary lookup.
- `MorseMap.cs` – Stores the bidirectional mappings between alphanumeric characters/symbols and their Morse representations.
- `MorsePlayer.cs` – Plays the Morse Code using `Console.Beep()`. Handles timing between dots, dashes, letters, and words.

##  Insights & Highlights

-  **Separation of Concerns**  
  Each core functionality (encoding, decoding, mapping, playback) is implemented in its own class: `MorseEncoder`, `MorseDecoder`, `MorseMap`, and `MorsePlayer`. This modular structure promotes better readability, testing, and maintenance.
 **Bidirectional Mapping**  
  The `MorseMap` class uses a static constructor to automatically generate a reverse mapping from Morse code to characters. This eliminates manual duplication and ensures consistency between encoding and decoding processes.
**Audio Playback Precision**  
  The `MorsePlayer` class handles tone playback using `Console.Beep()` with precise timing:  
  - Dot = 1 unit  
  - Dash = 3 units  
  - Space between letters = 3 units  
  - Space between words ("/") = 7 units
**Input Validation & User Guidance**  
  The console UI guides the user with clear instructions and validations for empty inputs or unsupported characters. It also offers an optional playback feature after encoding.
**Extendability**  
  This project can be easily extended with:
  - A GUI using WinForms or WPF
  - Support for file input/output
  - Morse code visualization with animations


##  **Description of the Morse Code Logic**

###  **Encoding Logic**

- Each letter in your text is **mapped** to its Morse equivalent using a dictionary.
- Spaces between letters are represented by `" "`, and spaces between words by `"/"`.
- The encoded Morse string is built and returned to the user.

###  **Decoding Logic**

- The Morse code input is split by spaces.
- Each symbol or group is matched back to the corresponding alphabet character.
- If `/` is detected, it inserts a space in the decoded message.

---
### Steps to use the program 

1.An option appears to enter text for encoding.
2.Type the text (e.g., HELLO).
3.The program converts it into Morse Code and displays it as output.
4.Then it plays the Morse Code using Console.Beep().
5.After that, you can type Morse Code for decoding (e.g., .... . .-.. .-.. ---), and the result will be displayed: HELLO.
6.Saving Morse Code to a File: After encoding, the result (Morse Code) will be automatically saved to a file named morse_code.txt in the same folder as the program.


## 🔊 **Morse Beep Playback**

The application also includes an audio player using:

```csharp
Console.Beep(frequency, duration);

---




