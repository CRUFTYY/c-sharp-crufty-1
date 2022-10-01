#pragma once

#include <string>
#include <vector>
#include <iostream>
#include <memory>

namespace ConsoleApp2
{
	class Program : public std::enable_shared_from_this<Program>
	{
	public:
		static void Main(std::vector<std::wstring> &args);

	};
}
