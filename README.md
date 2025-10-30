# C# Targilim

Small C# solutions (Visual Studio) from my learning process.  
Each folder is a standalone solution (`.sln`) with its own project files.

---

## 📂 Structure
targilim/
├─ targil6/ # arrays + filtering (>= 10) → prints both arrays
├─ targil6.2/ # (to fill) second variant for targil 6
├─ sol5/ # (to fill) solution 5
├─ sol6/ # improved filtering + voting simulator
├─ Targil8/ # (to fill) exercise 8
└─ studentMis/ # (to fill) student management exercise


> Repo folders visible here: `targil6`, `targil6.2`, `sol5`, `sol6`, `Targil8`, `studentMis`.  
> Add a short note under each as you go. 

---

## 🧾 Highlights

### `targil6`
- Reads 5 numbers, copies those **≥ 10** into a second array, and prints both arrays.  
- Straightforward console app (no input validation).

### `sol6`
- Two parts in one program:
  1) Reads numbers and collects those **> 10** with clearer printing and simple validation.
  2) **Voting simulator** for 6 parties: accepts votes, `-1` ends input, handles invalid entries, finds winners (supports ties), and repeats until there’s a single winner.

> Tip: If both `targil6` and `sol6` exist in the repo, keep both — one shows the basic version, the other shows the extended/cleaned approach.

---

## ⚙️ How to Run
1. Open a folder, then double-click the `.sln` file (e.g., `sol6.sln`) in **Visual Studio**.
2. Restore packages if prompted (Visual Studio will do this automatically).
3. **Run**: `Ctrl + F5` (Start Without Debugging) or the green **Run** button.

---

## 🧰 Tools
- **Language:** C#
- **IDE:** Visual Studio
- **Target:** .NET / .NET Framework (depending on the specific task)

---

## ✅ Next steps (optional)
- Add a short `README.md` **inside each folder** (what it does, how to run).
- Add screenshots of console output for quick preview.
- Add a root `.gitignore` to keep the repo clean:
bin/
obj/
.vs/
*.user
*.suo
.vscode/
.idea/

---

⭐ Learning C# by building small, focused programs — one task at a time.
