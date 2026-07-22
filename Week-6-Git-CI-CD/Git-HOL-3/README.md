\# Git-HOL-2 – Using .gitignore



\## Overview



This hands-on exercise demonstrates how to use the `.gitignore` file in Git to ignore unwanted files and directories from version control. Git automatically excludes files and folders specified in `.gitignore` while tracking the remaining project files.



\---



\## Objectives



\- Understand the purpose of `.gitignore`.

\- Ignore unwanted files using Git.

\- Ignore directories from version control.

\- Verify ignored files using Git status.



\---



\## Prerequisites



\- Git installed

\- Git Bash

\- GitHub Account

\- Existing Git Repository



\---



\## Project Structure



```text

Git-HOL-2/

│

├── Commands/

│   ├── GitStatusBeforeIgnore.png

│   ├── GitIgnoreFile.png

│   ├── GitStatusAfterIgnore.png

│   ├── GitCommit.png

│   └── GitHubPush.png

│

├── .gitignore

├── error.log

├── log/

│   └── application.log

│

└── README.md

```



\---



\## Steps Performed



\### Step 1



Created a Git repository.



```bash

git init

```



\---



\### Step 2



Created a log file.



```bash

echo "Application Error" >> error.log

```



\---



\### Step 3



Created a log directory.



```bash

mkdir log

```



Created a log file.



```bash

echo "Log File" >> log/application.log

```



\---



\### Step 4



Checked repository status.



```bash

git status

```



Git displayed both the log file and log folder as untracked.



\---



\### Step 5



Created a `.gitignore` file.



Contents:



```gitignore

\*.log

log/

```



\---



\### Step 6



Checked Git status again.



The `.log` file and `log` folder were ignored by Git.



\---



\### Step 7



Committed the project.



```bash

git add .

git commit -m "Completed Git-HOL-2"

```



\---



\### Step 8



Pushed the project to GitHub.



```bash

git push origin main

```



\---



\## Files Ignored



\- All `.log` files

\- `log` directory



\---



\## Learning Outcome



After completing this hands-on, I learned:



\- How `.gitignore` works.

\- How to ignore files and folders in Git.

\- How Git excludes ignored files from version control.

\- How to verify ignored files using `git status`.

