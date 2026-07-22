# Git-HOL-5 - Clean Up and Push Back to Remote Git

## Overview

This hands-on demonstrates how to synchronize a local Git repository with a remote GitHub repository. It includes verifying the repository status, listing available branches, pulling the latest changes from the remote repository, pushing local commits to GitHub, and verifying that the changes are successfully reflected in the remote repository.

---

## Objectives

- Understand how to synchronize a local repository with a remote repository.
- Verify the current repository status.
- List all available Git branches.
- Pull the latest changes from GitHub.
- Push local changes to the remote repository.
- Verify the successful synchronization on GitHub.

---

## Prerequisites

- Git installed and configured.
- Git Bash installed.
- GitHub account.
- Remote repository connected with the local repository.

---

## Folder Structure

```
Git-HOL-5/
│
├── Commands/
│   ├── GitStatusClean.png
│   ├── GitBranches.png
│   ├── GitPull.png
│   ├── GitPush.png
│   └── GitHubRepository.png
│
└── README.md
```

---

## Commands Executed

### Navigate to the Repository

```bash
cd /c/cogznt/Cognizant-Deep-Skilling-DotNetFSE-5.0
```

### Verify Repository Status

```bash
git status
```

### List All Available Branches

```bash
git branch -a
```

### Pull Latest Changes from Remote Repository

```bash
git pull origin main
```

### Push Local Changes to GitHub

```bash
git push origin main
```

---

## Screenshots

The **Commands** folder contains screenshots captured during each step of the hands-on.

| Screenshot | Description |
|------------|-------------|
| GitStatusClean.png | Repository status showing a clean working tree |
| GitBranches.png | Display of all available local and remote branches |
| GitPull.png | Pulling the latest changes from the remote repository |
| GitPush.png | Successfully pushing local changes to GitHub |
| GitHubRepository.png | GitHub repository showing the latest synchronized changes |

---

## Outcome

Successfully completed the Git cleanup and remote synchronization process by:

- Verifying the repository was in a clean state.
- Listing all available Git branches.
- Pulling the latest changes from the remote repository.
- Pushing local changes to GitHub.
- Confirming that all updates were successfully reflected in the remote repository.

---

## Technologies Used

- Git
- Git Bash
- GitHub
- Visual Studio Code

---

## Conclusion

This hands-on provided practical experience with synchronizing a local Git repository with a remote GitHub repository. By performing pull and push operations, the repository remained up-to-date across both local and remote environments, ensuring proper version control and collaboration.