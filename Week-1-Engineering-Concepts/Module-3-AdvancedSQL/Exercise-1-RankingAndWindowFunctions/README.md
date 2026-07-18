\# Exercise 1 - Ranking and Window Functions



\## Objective



Implement SQL Ranking and Window Functions using:



\- ROW\_NUMBER()

\- RANK()

\- DENSE\_RANK()

\- OVER()

\- PARTITION BY



\## Scenario



An Online Retail Store wants to identify the top expensive products within each category.



\## Steps Performed



\- Created OnlineRetailStore database.

\- Created Products table.

\- Inserted sample product records.

\- Used ROW\_NUMBER() to assign unique rankings.

\- Used RANK() to demonstrate ranking with gaps.

\- Used DENSE\_RANK() to demonstrate ranking without gaps.

\- Used PARTITION BY Category and ORDER BY Price DESC.

\- Retrieved Top 3 expensive products from every category.



\## Output



The query successfully displays ranked products for each category and returns the Top 3 products based on price.

