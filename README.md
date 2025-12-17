**Project Overview**

This project demonstrates a Dictionary API Web Application built using .NET 7 Web API and Clean/Onion Architecture principles.

The API consumes the Free Dictionary API(https://dictionaryapi.dev/)
 and provides dictionary data like:

  * Word definitions
  * Phonetics
 * Meanings, synonyms, and antonyms
 
The project follows Clean Architecture / Onion Architecture:
**Layer Responsibilities**:
| Layer              | Responsibility                                |
| ------------------ | --------------------------------------------- |
| **Domain**         | Core entities and models                      |
| **Application**    | Interfaces & use cases (business rules)       |
| **Infrastructure** | External API calls, HttpClient, configuration |
| **API**            | Presentation layer, Controllers, DI setup     |

**Features**

 * Fetch word details from the external Free Dictionary API
 * Returns structured JSON with:
 * Word, Phonetic, Meaning, Synonyms, Antonyms
 * Follows Clean Architecture principles
 * Configurable API URL via appsettings.json
 * Exception handling for word not found

 ___________________________________________________________________________________
  License MIT License © 2025
