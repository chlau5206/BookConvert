# ePub Converter (CHS → CHT)
/// <summary>
/// Project: ConvertEPub version 2.0
/// Project type: C# .NET Framework 4.8
/// Date: May 1, 2022
/// Purpose: A C# utility that converts Simplified Chinese ePub books to Traditional Chinese.
/// Update #1: add Windows form UI
/// Update #2: Use Convertor.dll for main module.
/// Condiction: GB2312 ePub must be in UTF-8
/// License: MIT License
/// </summary>

project_description
   ePubConverter is a practical C# utility that converts Simplified Chinese (CHS)
   ePub books into Traditional Chinese (CHT). The tool extracts the ePub contents,
   processes each XHTML file, performs character-by-character mapping, and rebuilds
   the final ePub.

   The converter uses a <strong>1-to-1 array-based mapping</strong> instead of a
   dictionary lookup. This ensures deterministic behavior, O(1) direct index access,
   and fully reversible mapping. It is designed as a clean, reliable command-line tool
   for readers who prefer Traditional Chinese formatting.

features
   "1-to-1 array-based CHS → CHT mapping",
   "Reversible mapping capability",
   "Processes XHTML chapters safely and consistently",
   "Rebuilds the final ePub with preserved structure",
   "Command-line interface for quick usage",
   "Error handling for malformed or unusual ePub files"


architecture_notes
   The converter extracts the ePub (ZIP) into a temporary working directory, scans
   all XHTML files, and applies a <strong>direct index-based character mapping</strong>
   to convert Simplified Chinese to Traditional Chinese. This avoids dictionary
   lookups and ensures predictable, reversible transformations.

   After processing, the tool rebuilds the ePub archive while preserving metadata,
   images, and folder structure. The project is written in C# using .NET, with a
   focus on clarity, reliability, and predictable output.
 
