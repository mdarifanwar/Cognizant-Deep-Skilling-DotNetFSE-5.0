\# Git-HOL-1 – Git Basics and Repository Management



\## Overview



This hands-on exercise demonstrates the basic Git workflow, including Git installation verification, configuration, repository creation, file tracking, committing changes, and pushing the project to GitHub. The objective is to understand the fundamental Git commands used for version control.



\---



\## Objectives



\- Verify Git installation.

\- Configure Git username and email.

\- Configure the default editor.

\- Create a local Git repository.

\- Create and manage files using Git.

\- Track file changes.

\- Commit changes to the local repository.

\- Push the project to the GitHub remote repository.



\---



\## Software Requirements



\- Git Bash

\- Git

\- Notepad++

\- GitHub Account

\- Windows OS



\---



\## Project Folder Structure



```text

Git-HOL-1/

│

├── Commands/

│   ├── GitVersion.png

│   ├── GitConfiguration.png

│   ├── GitInit.png

│   ├── WelcomeFileCreated.png

│   ├── WelcomeFileContent.png

│   ├── GitStatusBeforeAdd.png

│   ├── GitStatusAfterAdd.png

│   ├── GitCommit.png

│   ├── GitStatusAfterCommit.png

│   └── GitHubPush.png

│

├── new1.txt

└── README.md

```



\---



\## Steps Performed



\### Step 1 – Verified Git Installation



Verified that Git was installed correctly using:



```bash

git --version

```



\---



\### Step 2 – Configured Git



Configured Git with the user name and email.



```bash

git config --global user.name "Md Arif Ansari"



git config --global user.email "your-email@example.com"

```



Verified the configuration.



```bash

git config --global --list

```



\---



\### Step 3 – Configured Notepad++



Configured Notepad++ as the default editor for Git.



```bash

git config --global core.editor "notepad++.exe -multiInst -nosession"

```



\---



\### Step 4 – Created a Git Repository



Initialized a new Git repository.



```bash

git init GitDemo

```



Entered the repository.



```bash

cd GitDemo

```



\---



\### Step 5 – Created a Text File



Created a text file.



```bash

echo "Welcome to the version control" >> welcome.txt

```



Verified the contents.



```bash

cat welcome.txt

```



\---



\### Step 6 – Checked Repository Status



Checked the repository status.



```bash

git status

```



Git displayed the file as \*\*Untracked\*\*.



\---



\### Step 7 – Added File to Staging Area



Added the file to Git staging.



```bash

git add welcome.txt

```



Verified the status again.



```bash

git status

```



The file appeared under \*\*Changes to be committed\*\*.



\---



\### Step 8 – Committed Changes



Committed the staged file.



```bash

git commit -m "Initial commit"

```



\---



\### Step 9 – Verified Commit



Checked repository status.



```bash

git status

```



Checked commit history.



```bash

git log --oneline

```



\---



\### Step 10 – Pushed to GitHub



Connected the local repository with GitHub and successfully pushed the project.



```bash

git remote add origin <repository-url>



git push -u origin master

```



The project is now available in the GitHub repository.



\---



\## Git Commands Used



```bash

git --version

git config --global user.name

git config --global user.email

git config --global --list

git init GitDemo

cd GitDemo

echo "Welcome to the version control" >> welcome.txt

cat welcome.txt

git status

git add welcome.txt

git commit -m "Initial commit"

git log --oneline

git remote add origin <repository-url>

git push -u origin master

```



\---



\## Output



The project was successfully:



\- Git configured

\- Repository initialized

\- File created

\- File tracked

\- Changes committed

\- Repository pushed to GitHub



All screenshots have been included in the \*\*Commands\*\* folder.



\---



\## Learning Outcome



After completing this hands-on, I learned:



\- Basic Git commands

\- Git repository creation

\- Git staging area

\- Git commits

\- Local repository management

\- Connecting Git with GitHub

\- Pushing local changes to a remote repository

