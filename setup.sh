for category in behavioral creational structural; do
  for notebook in notebooks/$category/*.ipynb; do
    # Obtener el nombre del patrón desde el archivo notebook
    pattern=$(basename "$notebook" .ipynb)

    # Insertar contenido en el notebook
    echo '{
     "cells": [
      {
       "cell_type": "markdown",
       "metadata": {},
       "source": [
        "# '$pattern' Pattern\\n",
        "This notebook demonstrates the use of the '$pattern' design pattern in Python."
       ]
      },
      {
       "cell_type": "code",
       "execution_count": null,
       "metadata": {},
       "outputs": [],
       "source": [
        "from src.'$category'.'$pattern' import '$pattern'\\n",
        "\\n",
        "# Arrange\\n",
        "# Set up any initial data or states\\n",
        "\\n",
        "# Act\\n",
        "# Call the methods or functions to test the behavior\\n",
        "\\n",
        "# Assert\\n",
        "# Verify that the expected outcomes are correct\\n",
        "pass"
       ]
      }
     ],
     "metadata": {
      "kernelspec": {
       "display_name": "Python 3",
       "language": "python",
       "name": "python3"
      },
      "language_info": {
       "codemirror_mode": {
        "name": "ipython",
        "version": 3
       },
       "file_extension": ".py",
       "mimetype": "text/x-python",
       "name": "python",
       "nbconvert_exporter": "python",
       "version": "3.9.7"
      }
     },
     "nbformat": 4,
     "nbformat_minor": 5
    }' > "$notebook"

    echo "Notebook created for $pattern in $notebook"
  done
done
