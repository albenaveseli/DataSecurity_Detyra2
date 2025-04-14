# 🔐 Morse Code Encoder & Decoder – Console App in C#

This project was created as part of the **Data Security** class assignment (2025). It includes **encoding, decoding, and audio playback** of Morse Code using `Console.Beep()` in a console-based C# application.

---

## ✅ **How to Run the Program**

1. Open the solution in **JetBrains Rider**, **Visual Studio**, or any other C# IDE.
2. Run the program.
3. Follow the instructions in the console:

   - 👉 **Enter a message to encode** – type a word or sentence.
   - 🧠 The app encodes it into **Morse code** and displays the result.
   - 🔊 Then, it **plays the Morse code** using beeps (`Console.Beep()`).
   - 📝 Next, you can **enter Morse code** manually to decode.
   - 💬 The decoded text will be shown.

---

## 📄 **Description of the Morse Code Logic**

### 🔤 **Encoding Logic**

- Each letter in your text is **mapped** to its Morse equivalent using a dictionary.
- Spaces between letters are represented by `" "`, and spaces between words by `"/"`.
- The encoded Morse string is built and returned to the user.

### 🧠 **Decoding Logic**

- The Morse code input is split by spaces.
- Each symbol or group is matched back to the corresponding alphabet character.
- If `/` is detected, it inserts a space in the decoded message.

---

## 🔊 **Morse Beep Playback**

The application also includes an audio player using:

```csharp
Console.Beep(frequency, duration);
