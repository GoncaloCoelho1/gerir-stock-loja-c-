-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 08-Fev-2024 às 20:10
-- Versão do servidor: 10.4.28-MariaDB
-- versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `loja`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `categorias`
--

CREATE TABLE `categorias` (
  `categoria_id` int(11) NOT NULL,
  `categoria_nome` text NOT NULL,
  `categoria_fornecedor_id` int(10) NOT NULL,
  `categoria_codigo` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `categorias`
--

INSERT INTO `categorias` (`categoria_id`, `categoria_nome`, `categoria_fornecedor_id`, `categoria_codigo`) VALUES
(1, 'camisolas manga curta', 1, 100),
(2, 'camisolas manga comprida', 1, 101),
(3, 'relogios', 2, 102),
(4, 'sapatos', 3, 103),
(10, 'Carteiras', 1, 104),
(11, 'calças ', 2, 105),
(12, 'calçoes', 2, 106),
(13, 'telemoveis', 3, 107),
(14, 'Computadores', 3, 108);

-- --------------------------------------------------------

--
-- Estrutura da tabela `compras`
--

CREATE TABLE `compras` (
  `compra_id` int(11) NOT NULL,
  `compra_trabalhador_id` int(11) NOT NULL,
  `compra_produto_codigo` varchar(1000) NOT NULL,
  `compra_valor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `compras`
--

INSERT INTO `compras` (`compra_id`, `compra_trabalhador_id`, `compra_produto_codigo`, `compra_valor`) VALUES
(3, 1, '1001, 1001, 1001, 1001', 8),
(6, 1, '1000, 1000', 4),
(9, 7, '1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001', 32),
(10, 7, '1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001', 200),
(11, 7, '1011, 1011, 1011, 1011, 1011, 1011, 1011, 1011, 1011, 1011, 1011, 1011, 1011, 1011, 1012, 1012', 80),
(12, 7, '1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020, 1020', 2000),
(13, 7, '1013, 1013', 20),
(14, 7, '1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1013, 1022, 1022, 1022, 1022, 1022, 1022, 1022, 1022, 1022, 1022', 1300);

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedores`
--

CREATE TABLE `fornecedores` (
  `fornecedor_id` int(11) NOT NULL,
  `fornecedor_nome` text NOT NULL,
  `fornecedor_morada` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `fornecedores`
--

INSERT INTO `fornecedores` (`fornecedor_id`, `fornecedor_nome`, `fornecedor_morada`) VALUES
(1, 'Manuel Luis', 'Rua das Flores'),
(2, 'João Manuel', 'Rua da China'),
(3, 'Pedro joaquim', 'Rua do Japão');

-- --------------------------------------------------------

--
-- Estrutura da tabela `niveis_acesso`
--

CREATE TABLE `niveis_acesso` (
  `nivel_id` int(11) NOT NULL,
  `nivel_nome` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `niveis_acesso`
--

INSERT INTO `niveis_acesso` (`nivel_id`, `nivel_nome`) VALUES
(1, 'Administrador'),
(2, 'funcionario');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE `produtos` (
  `produto_id` int(11) NOT NULL,
  `produto_nome` text NOT NULL,
  `produto_categoria_codigo` int(11) NOT NULL,
  `produto_fornecedor_id` int(11) NOT NULL,
  `produto_quantidade_stock` int(11) NOT NULL,
  `produto_valor_compra` decimal(10,0) NOT NULL,
  `produto_valor_venda` decimal(10,0) NOT NULL,
  `produto_codigo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`produto_id`, `produto_nome`, `produto_categoria_codigo`, `produto_fornecedor_id`, `produto_quantidade_stock`, `produto_valor_compra`, `produto_valor_venda`, `produto_codigo`) VALUES
(3, 'camisola amarela', 100, 1, 139, 2, 7, 1001),
(18, 'camisola preta', 101, 3, 100, 10, 300, 1003),
(24, 'casio', 102, 1, 5, 10, 100, 1004),
(25, 'rolex', 102, 2, 5, 100, 1000, 1005),
(26, 'seiko', 102, 3, 13, 50, 300, 1006),
(27, 'computador xpto', 108, 3, 4, 500, 2000, 1007),
(28, 'samsung', 107, 3, 30, 200, 1000, 1008),
(29, 'iphone', 107, 3, 20, 200, 1000, 1009),
(30, 'calçoes verdes', 106, 2, 100, 5, 20, 1010),
(31, 'calçoes azuis', 106, 2, 44, 5, 20, 1011),
(32, 'calçoes pretos', 106, 2, 37, 5, 30, 1012),
(33, 'calças pretas', 105, 2, 122, 10, 50, 1013),
(34, 'calças amarelas', 105, 2, 20, 10, 35, 1014),
(35, 'camisola azul', 100, 1, 100, 2, 10, 1015),
(36, 'camisola laranja', 100, 1, 200, 3, 15, 1016),
(37, 'camisola roxa', 101, 1, 50, 5, 20, 1017),
(38, 'camisola castanha', 101, 1, 53, 2, 25, 1018),
(39, 'carteira amarela', 104, 1, 37, 20, 200, 1019),
(40, 'carteira preta', 104, 1, 145, 20, 149, 1020),
(41, 'sapatos nike', 103, 3, 7, 30, 300, 1021),
(42, 'sapatos adidas', 103, 3, 40, 30, 200, 1022);

-- --------------------------------------------------------

--
-- Estrutura da tabela `trabalhadores`
--

CREATE TABLE `trabalhadores` (
  `trabalhador_id` int(11) NOT NULL,
  `trabalhador_nome` text NOT NULL,
  `trabalhador_email` varchar(50) NOT NULL,
  `trabalhador_senha` varchar(100) NOT NULL,
  `trabalhador_nivel` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `trabalhadores`
--

INSERT INTO `trabalhadores` (`trabalhador_id`, `trabalhador_nome`, `trabalhador_email`, `trabalhador_senha`, `trabalhador_nivel`) VALUES
(4, 'Joao', 'joao@funcionario.pt', '$2a$11$Q3ZZd3LwUVXYDh76noE1hObaj3fLfk.fUkVfYlGRr/Vk0HT38Ja4O', 2),
(7, 'Goncalo', 'goncalo@admin.pt', '$2a$11$K.p5cXTc/iVW1rW9qB4y9.K4Ho/Z/mYge13VkP314hns9BMnKn.qK', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `vendas`
--

CREATE TABLE `vendas` (
  `venda_id` int(11) NOT NULL,
  `venda_trabalhador_id` int(11) NOT NULL,
  `venda_produto_codigo` varchar(1000) NOT NULL,
  `venda_valor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `vendas`
--

INSERT INTO `vendas` (`venda_id`, `venda_trabalhador_id`, `venda_produto_codigo`, `venda_valor`) VALUES
(36, 4, '1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001', 280),
(37, 7, '1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001, 1001', 84),
(38, 7, '1001, 1001', 14),
(39, 4, '1021, 1021, 1021', 900),
(40, 4, '1004, 1004, 1004', 300),
(41, 4, '1019, 1019, 1019, 1004', 700),
(42, 4, '1004, 1001, 1001, 1001, 1001, 1001', 135);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`categoria_id`),
  ADD KEY `categoria_codigo` (`categoria_codigo`);

--
-- Índices para tabela `compras`
--
ALTER TABLE `compras`
  ADD PRIMARY KEY (`compra_id`);

--
-- Índices para tabela `fornecedores`
--
ALTER TABLE `fornecedores`
  ADD PRIMARY KEY (`fornecedor_id`);

--
-- Índices para tabela `niveis_acesso`
--
ALTER TABLE `niveis_acesso`
  ADD PRIMARY KEY (`nivel_id`);

--
-- Índices para tabela `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`produto_id`),
  ADD KEY `produto_fornecedor_id` (`produto_fornecedor_id`),
  ADD KEY `produto_categoria_id` (`produto_categoria_codigo`),
  ADD KEY `produto_codigo` (`produto_codigo`);

--
-- Índices para tabela `trabalhadores`
--
ALTER TABLE `trabalhadores`
  ADD PRIMARY KEY (`trabalhador_id`),
  ADD KEY `trabalhador_nivel` (`trabalhador_nivel`);

--
-- Índices para tabela `vendas`
--
ALTER TABLE `vendas`
  ADD PRIMARY KEY (`venda_id`),
  ADD KEY `venda_trabalhador_id` (`venda_trabalhador_id`),
  ADD KEY `venda_produto_codigo` (`venda_produto_codigo`(768));

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `categorias`
--
ALTER TABLE `categorias`
  MODIFY `categoria_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT de tabela `compras`
--
ALTER TABLE `compras`
  MODIFY `compra_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT de tabela `fornecedores`
--
ALTER TABLE `fornecedores`
  MODIFY `fornecedor_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `produtos`
--
ALTER TABLE `produtos`
  MODIFY `produto_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- AUTO_INCREMENT de tabela `trabalhadores`
--
ALTER TABLE `trabalhadores`
  MODIFY `trabalhador_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT de tabela `vendas`
--
ALTER TABLE `vendas`
  MODIFY `venda_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `produtos`
--
ALTER TABLE `produtos`
  ADD CONSTRAINT `produtos_ibfk_1` FOREIGN KEY (`produto_fornecedor_id`) REFERENCES `fornecedores` (`fornecedor_id`),
  ADD CONSTRAINT `produtos_ibfk_2` FOREIGN KEY (`produto_categoria_codigo`) REFERENCES `categorias` (`categoria_codigo`);

--
-- Limitadores para a tabela `trabalhadores`
--
ALTER TABLE `trabalhadores`
  ADD CONSTRAINT `trabalhadores_ibfk_1` FOREIGN KEY (`trabalhador_nivel`) REFERENCES `niveis_acesso` (`nivel_id`);

--
-- Limitadores para a tabela `vendas`
--
ALTER TABLE `vendas`
  ADD CONSTRAINT `vendas_ibfk_1` FOREIGN KEY (`venda_trabalhador_id`) REFERENCES `trabalhadores` (`trabalhador_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
