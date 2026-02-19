# Meu Primeiro Ambiente VR — Simulador de Treinamento de Empilhadeira (Unity + Meta Quest)

Projeto final da 1ª fase do curso Web 3.0 / XR: criação de um ambiente simples em VR usando **Unity** (com **Meta XR SDK** opcional/ desejável), aplicando os conceitos básicos de XR e organização de projeto.

## 🎯 Objetivo do Projeto
Demonstrar compreensão dos fundamentos de XR por meio da criação de um **ambiente navegável simples**, com cena organizada, objetos 3D posicionados de forma coerente e configuração técnica pronta para **Android (Meta Quest)**.

A proposta desta cena é um **simulador básico de treinamento de empilhadeira**, usando um asset low poly de forklift.

---

## ✅ Requisitos atendidos
### Configuração técnica
- [x] Projeto Unity criado em versão compatível (Unity 6 / 6000+)
- [x] **Meta XR All-in-One SDK** instalado e configurado
- [x] Build configurado para **Android (Meta Quest)**
- [x] **XR Plugin Management** configurado
- [x] **OpenXR** habilitado em PC e Android
- [x] Projeto validado com:
  - Meta XR Tools → Project Setup Tool
  - Project Validation (correções aplicadas)
- [x] Movimentação inicial possível pelo **PC** (não depende exclusivamente do headset)

### Ambiente virtual
- [x] Cena com **mínimo de 5 objetos 3D** (primitivos e/ou assets)
- [x] Plano/terreno de chão para navegação
- [x] Skybox configurado
- [x] Objetos organizados para formar um ambiente reconhecível (treinamento)

### Organização e qualidade
- [x] Hierarquia organizada com “pastas” (GameObjects) e estrutura lógica
- [x] Nomenclatura clara e consistente
- [x] Repositório limpo (somente **Assets**, **ProjectSettings**, **Packages**)

---

## 🧰 Tecnologias e Ferramentas
- **Unity** (Unity 6 / 6000+)
- **Meta XR All-in-One SDK**
- **XR Plugin Management**
- **OpenXR**
- Plataforma alvo: **Android (Meta Quest)**

---

## 📦 Assets utilizados
- **Low Poly Forklift** (Asset Store)

> Observação: alguns assets da Asset Store podem não estar distribuídos diretamente no repositório por licença.  
> Se algo estiver faltando ao clonar, siga a seção **“Como recriar o ambiente”**.

---

## 🗂️ Estrutura do Repositório
O repositório contém apenas as pastas necessárias do projeto Unity:

- `Assets/`
- `ProjectSettings/`
- `Packages/`

---

## 🚀 Como recriar o ambiente (passo a passo)
### 1) Instalar Unity
1. Fazer inscrição no **Plano Unity Student**:  
   https://unity.com/pt/products/unity-student
2. Instalar o **Unity Hub**:  
   https://unity.com/download
3. Instalar o **Unity Editor (Unity 6 / 6000+)**
4. Incluir o módulo **Android Build Support** (pode ser adicionado depois)

### 2) Criar projeto
1. Criar projeto usando o template **Universal 3D**

### 3) Instalar Meta XR All-in-One SDK
1. Baixar na Asset Store:  
   https://assetstore.unity.com/packages/tools/integration/meta-xr-all-in-one-sdk269657
2. Na Unity:
   - `Window → Package Manager`
   - Aba lateral: `My Assets`
   - Selecionar **Meta XR All-in-One SDK**
   - `Download` (se necessário) → `Import`

### 4) Trocar build para Android (Meta Quest)
1. `File → Build Profiles`
2. `Platforms → Android`
3. `Switch Platform`

### 5) Configurar XR Plugin Management + OpenXR
1. `Project Settings → XR Plug-in Management`
2. `Install XR Plugin Management` (se ainda não estiver instalado)
3. Em **PC** e **Android**:
   - Habilitar **OpenXR**

### 6) Validar e corrigir setup do Meta XR
1. Rodar **Project Validation** e aceitar as correções recomendadas
2. `Meta XR Tools → Project Setup Tool`
3. Aceitar todas as correções sugeridas

### 7) Importar asset da empilhadeira
- Importar o asset **Low Poly Forklift** via Asset Store no projeto.

### 8) Converter Render Pipeline (se necessário)
- Usar o **Render Pipeline Converter** para adequar materiais/shaders ao pipeline do projeto.


---

## 🕹️ Como rodar / testar
### Teste no PC (movimentação inicial)
- Abrir a cena principal (ex: `Assets/Scenes/Main.unity`)
- Pressionar **Play**
- Usar o modo de navegação configurado para PC (conforme implementado no projeto)

### Build para Meta Quest (Android)
- `File → Build Profiles → Android`
- Conferir se a plataforma está em **Android**
- `Build And Run` (com o device configurado)

---

## 🧠 Aprendizados e Reflexão
Este projeto consolidou:
- Criação e organização de um projeto Unity para XR
- Instalação e validação do Meta XR SDK
- Configuração de OpenXR e pipeline de build Android (Meta Quest)
- Estruturação de cena com objetos 3D, chão e skybox
- Boas práticas de hierarquia e nomenclatura

---

## 📌 Próximos passos (ideias de evolução)
- Interações de treinamento (pegar/soltar pallets, checkpoints, cones)
- Sistema de pontuação e feedback (tempo, colisões, precisão)
- UI simples de instruções dentro da cena
- Física e colisões mais realistas

---

## 👤 Autor
Gabriel Alves Baltazar
