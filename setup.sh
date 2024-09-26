#!/bin/bash

# Archivos .csproj
MAIN_PROJECT_FILE="DesignPatterns/DesignPatterns.csproj"
TEST_PROJECT_FILE="DesignPatterns.Tests/DesignPatterns.Tests.csproj"

# Hacer una copia de seguridad de los archivos .csproj por si acaso
cp $MAIN_PROJECT_FILE "$MAIN_PROJECT_FILE.bak"
cp $TEST_PROJECT_FILE "$TEST_PROJECT_FILE.bak"

# Recorrer las carpetas creational, structural y behavioral
for dir in creational structural behavioral; do
  for pattern in $(ls $dir); do

    # Crear el nombre en CamelCase para los archivos de C#
    pattern_camel=$(echo "$pattern" | sed -r 's/(-)([a-z])/\U\2/g' | sed 's/^./\U&/')

    # Directorio para los tests
    TESTS_DIR="$dir/$pattern/tests"

    # Crear carpeta de tests si no existe
    mkdir -p $TESTS_DIR

    # Ruta a la clase principal .cs
    CS_FILE="$dir/$pattern/${pattern_camel}.cs"
    # Ruta al archivo de test .cs
    CS_TEST_FILE="$dir/$pattern/tests/${pattern_camel}Tests.cs"
    # Ruta al archivo de test Python
    PY_TEST_FILE="$dir/$pattern/tests/test_$pattern.py"

    # Añadir la clase principal al archivo .csproj si no está ya añadida
    if ! grep -q "$CS_FILE" $MAIN_PROJECT_FILE; then
      echo "Adding $CS_FILE to $MAIN_PROJECT_FILE..."
      sed -i "/<\/PropertyGroup>/a\ \ \ \ <Compile Include=\"$CS_FILE\" />" $MAIN_PROJECT_FILE
    fi

    # Añadir la clase de test al archivo de tests .csproj si no está ya añadida
    if ! grep -q "$CS_TEST_FILE" $TEST_PROJECT_FILE; then
      echo "Adding $CS_TEST_FILE to $TEST_PROJECT_FILE..."
      sed -i "/<\/PropertyGroup>/a\ \ \ \ <Compile Include=\"$CS_TEST_FILE\" />" $TEST_PROJECT_FILE
    fi

    # Generar test en Python si no existe
    if [ ! -f $PY_TEST_FILE ]; then
      echo "Creating pytest file for $pattern..."
      echo "import pytest

def test_$pattern():
    # Arrange
    # Act
    # Assert
    assert True" > $PY_TEST_FILE
    fi

  done
done

echo "All .cs, .cs test files, and pytest files have been created and added to the .csproj files."
