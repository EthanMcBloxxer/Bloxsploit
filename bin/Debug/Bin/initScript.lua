local HttpService = game:GetService("HttpService")
--local Host = "http://localhost:9000"
local newcfunction = function(f) return f end
getfenv(0).getgenv = function() return getfenv(0) end
getgenv().newcclosure = newcfunction(newcfunction)
newcfunction = nil
getgenv().newlclosure = newcclosure(function(f) f() end) -- useless lol
getgenv().make_writeable = newcclosure(function(Table, Bool) if not Bool then Bool = false end return setreadonly(Table, Bool) end)
getgenv().make_readonly = newcclosure(function(Table, Bool) if not Bool then Bool = true end return setreadonly(Table, Bool) end)
getgenv().getreg = debug.getregistry
getgenv().getregistry = getreg
getgenv().downloadstring = newcclosure(function(URL) return game:HttpGet(URL) end)
getgenv().download_string = downloadstring
debug.getrawmetatable = getrawmetatable

local BackupMetaTable = {}
for Iteration, Value in pairs(getrawmetatable(game)) do
    BackupMetaTable[Iteration] = Value
end

local function MakeWebsocketRequest(Destination, ...)
    local Parameters = {...}
    if not Parameters[1] then
        error("Invalid Syntax.\nUsage: MakeWebsocketRequest('/wrapper/writefile', {'filename', 'data'}, {'helloworld.txt', 'Hello, World!'})")
    elseif not Parameters[2] then
        error("Invalid Syntax.\nUsage: MakeWebsocketRequest('/wrapper/writefile', {'filename', 'data'}, {'helloworld.txt', 'Hello, World!'})")
    end

    for Iteration, Param in pairs(Parameters[1]) do
        if Iteration == 1 then
            Destination = Destination.."/?"..Param.."="..HttpService:UrlEncode(Parameters[2][Iteration])
        else
            Destination = Destination.."&"..Param.."="..HttpService:UrlEncode(Parameters[2][Iteration])
        end
    end

    return game:HttpGet(Host..Destination)
end

getgenv().fixmetatable = newcclosure(function()
    setrawmetatable(game, BackupMetaTable)
end)

getgenv().writefile = newcclosure(function(filename, data)
    if type(filename) ~= "string" then
        error("Expected string as argument 1.", 0)
    elseif type(data) ~= "string" then
        error("Expected string as argument 2.", 0)
    end

    local Status = MakeWebsocketRequest(
        "/wrapper/writefile", 
        {"filename", "data"}, 
        {filename, data}
    )

    if Status == "File written" then
        return true
    elseif Status == "Illegal extension name" then
        error("You are trying to save a file with a blacklisted extension.", 0)
        return false
    elseif Status == "Illegal directory" then
        error("You are trying to save a file out of the workspace directory.", 0)
        return false
    elseif Status == nil then
        error("Websocket error.", 0)
        return false
    end
end)
getgenv().write_file = writefile

getgenv().makefolder = newcclosure(function(filename)
    if type(filename) ~= "string" then
        error("Expected string as argument 1.", 0)
    end

    local Status = MakeWebsocketRequest(
        "/wrapper/writedir", 
        {"filename"}, 
        {filename}
    )

    if Status == "Directory written" then
        return true
    elseif Status == "Illegal directory" then
        error("You are trying to create a folder out of the workspace directory.", 0)
        return false
    end
end)
getgenv().make_folder = makefolder

getgenv().delfile = newcclosure(function(filename)
    if type(filename) ~= "string" then
        error("Expected string as argument 1.", 0)
    end

    local Status = MakeWebsocketRequest(
        "/wrapper/del", 
        {"filename", "isdir"}, 
        {filename, false}
    )

    if Status == "Deleted" then
        return true
    elseif Status == "Doesn't exist" then
        error("The specefied file doesn't exist.", 0)
        return false
    end
end)
getgenv().delete_file = delfile

getgenv().delfolder = newcclosure(function(filename)
    if type(filename) ~= "string" then
        error("Expected string as argument 1.", 0)
    end

    local Status = MakeWebsocketRequest(
        "/wrapper/del", 
        {"filename", "isdir"}, 
        {filename, true}
    )

    if Status == "Deleted" then
        return true
    elseif Status == "Doesn't exist" then
        error("The specefied file doesn't exist.", 0)
        return false
    end
end)
getgenv().delete_folder = delfolder

getgenv().readfile = newcclosure(function(filename)
    if type(filename) ~= "string" then
        error("Expected string as argument 1.", 0)
    end

    local Status = MakeWebsocketRequest(
        "/wrapper/readfile", 
        {"filename"}, 
        {filename}
    )

    if Status == "File doesn't exist" then
        error("The specefied file doesn't exist.", 0)
        return false
    else
        return Status
    end
end)
getgenv().read_file = writefile

getgenv().loadfile = newcclosure(function(filename) return loadstring(readfile(filename))() end)
getgenv().load_file = loadfile

getgenv().appendfile = newcclosure(function(filename, data)
    if type(filename) ~= "string" then
        error("Expected string as argument 1.", 0)
    elseif type(data) ~= "string" then
        error("Expected string as argument 2.", 0)
    end

    local oldData = readfile(filename)
    return writefile(filename, oldData..data)
end)
getgenv().append_file = appendfile

getgenv().getinstances = newcclosure(function()
    local Instances = {}

    for _, Table in pairs(debug.getregistry()) do
        if type(Table) == "table" then
            for _, _Instance in pairs(Table) do
                if typeof(_Instance) == "Instance" then
                    table.insert(Instances, _Instance)
                end
            end
        end
    end

    return Instances
end)
getgenv().get_instances = getinstances

getgenv().getnilinstances = newcclosure(function()
    local Instances = {}
    for _, _Instance in pairs(getinstances()) do
        if _Instance.Parent == nil then
            table.insert(Instances, _Instance)
        end
    end

    return Instances
end)
getgenv().get_nil_instances = getnilinstances

getgenv().getscripts = newcclosure(function()
    local Instances = {}
    for _, _Instance in pairs(getinstances()) do
        if _Instance:IsA("BaseScript") or _Instance:IsA("ModuleScript") then
            table.insert(Instances, _Instance)
        end
    end

    return Instances
end)
getgenv().get_scripts = getscripts

getgenv().getsenv = newcclosure(function(ScriptInstance)
    if typeof(ScriptInstance) ~= "Instance" then
        error("Expected an instance as argument 1.", 0)
    end

    if ScriptInstance:IsA("BaseScript") or ScriptInstance:IsA("ModuleScript") then
        for _, Function in pairs(debug.getregistry()) do
            if type(Function) == "function" then
                local FunctionEnvironment = getfenv(Function)
                if FunctionEnvironment.script then
                    if FunctionEnvironment.script == ScriptInstance then
                        return FunctionEnvironment
                    end
                end
            end
        end
    else
        error("Expected a BaseScript or ModuleScript as argument 1.", 0)
    end
end)

getgenv().getmenv = newcclosure(function(ScriptInstance) -- literally the same as require, ill just fallback to getsenv
    if typeof(ScriptInstance) ~= "Instance" then
        error("Expected an instance as argument 1.", 0)
    end

    if ScriptInstance:IsA("ModuleScript") then
        return require(ScriptInstance) or getsenv(ScriptInstance)
    else
        error("Expected a ModuleScript as argument 1.", 0)
    end
end)

getgenv().gettenv = newcclosure(function(Thread) -- who even uses gettenv :/
    if typeof(Thread) ~= "Thread" then
        error("Expected a thread as argument 1.", 0)
    end

    return debug.getfenv(Thread) -- debug.getfenv gets any env not just for functions but for userdatas, etc.
end)

getgenv().iscclosure = newcclosure(function(Function)
    if type(Function) ~= "function" then
        error("Expected a function as argument 1.", 0)
    end

    local info = debug.getinfo(Function)
    if info.what == "C" then
        return true
    elseif info.what == "Lua" then
        return false
    end
end)
getgenv().is_cclosure = iscclosure

getgenv().islclosure = newcclosure(function(Function)
    if type(Function) ~= "function" then
        error("Expected a function as argument 1.", 0)
    end

    local info = debug.getinfo(Function)
    if info.what == "C" then
        return false
    elseif info.what == "Lua" then
        return true
    end
end)
getgenv().is_lclosure = islclosure

getgenv().getinfo = debug.getinfo
getgenv().setupvalue = debug.setupvalue
getgenv().getupvalue = debug.getupvalue
getgenv().getupvalues = newcclosure(function(Function) -- Completely in lua :)
    if type(Function) ~= "function" then
        error("Expected a function as argument 1.", 0)
    end

    local StackLevel = 0
    local UpvalueCount = debug.getinfo(Function).nups
    local Upvalues = {}
    
    repeat
        local Name, Value = debug.getupvalue(Function, StackLevel)
        if Name then
            Upvalues[Name] = Value
        end
        
        StackLevel = StackLevel + 1
    until #Upvalues == UpvalueCount or StackLevel >= 4096 -- the stack can only hold so much
    return Upvalues
end)
getgenv().debug.getupvalues = getupvalues

getgenv().getcurrentstack = newcclosure(function()
    local Depth = 0
    repeat
        Depth = Depth + 1
    until not debug.getinfo(3 + Depth) or Depth >= 4096
    
    return Depth
end)
getgenv().get_current_stack = getcurrentstack
getgenv().debug.getcurrentstack = getcurrentstack

getgenv().getglobal = newcclosure(function(Function, Name)
    if type(Function) ~= "function" then
        error("Expected a function as argument 1.", 0)
    end

    return getfenv(Function)[Name]
end)
debug.getglobal = getglobal

getgenv().getglobals = newcclosure(function(Function) -- lol useless just use getfenv pls
    if type(Function) ~= "function" then
        error("Expected a function as argument 1.", 0)
    end

    return getfenv(Function)
end)
debug.getglobals = getglobals

local loadlibrary_files = game:GetObjects("rbxassetid://5477066973")[1]
loadlibrary_files.Name = math.random(0, 9999)
loadlibrary_files.Parent = nil

getgenv().getcallingscript = function()
    return getfenv(2).script
end

getgenv().LoadLibrary = newcclosure(function(Lib) -- if you still use loadlib ill be suprised
    if type(Lib) ~= "string" then
        error("Expected a string as argument 1.", 0)
    end

    for _, Module in pairs(loadlibrary_files:GetChildren()) do
        if Module.Name == Lib then
            return require(Module)
        end
    end

    error("That's not a valid library!", 0)
end)
getgenv().loadlib = LoadLibrary

getgenv()._require = require
getgenv().require = newcclosure(function(Module)
    if typeof(Module) == "Instance" then
        if Module:IsA("ModuleScript") then
            return _require(Module)
        else
            error("ModuleScript expected, got "..Module.ClassName..".", 0)
        end
    elseif type(Module) == "number" then
        local newModule = game:GetObjects("rbxassetid://"..Module)[1]
        newModule.Name = math.random(0, 9999)
        newModule.Parent = nil

        return _require(newModule)
    else
        error("Expected an Instance or number as argument 1.", 0)
        return false
    end
end)

-- neuron-only functions
getgenv().nrn = {} 
nrn.crypt = {}
nrn.crypt.md5 = newcclosure(function(data)
    local Status = MakeWebsocketRequest(
        "/wrapper/crypt/md5", 
        {"data"}, 
        {data}
    )

    return Status
end)

nrn.crypt.sha256 = newcclosure(function(data)
    local Status = MakeWebsocketRequest(
        "/wrapper/crypt/sha256", 
        {"data"}, 
        {data}
    )

    return Status
end)

nrn.crypt.base64enc = newcclosure(function(data)
    local Status = MakeWebsocketRequest(
        "/wrapper/crypt/base64", 
        {"data"}, 
        {data}
    )

    return Status
end)
nrn.crypt.base64encode = nrn.crypt.base64enc

nrn.crypt.base64dec = newcclosure(function(data)
    local Status = MakeWebsocketRequest(
        "/wrapper/crypt/base64", 
        {"data"}, 
        {data}
    )

    return Status
end)
nrn.crypt.base64encode = nrn.crypt.base64dec

nrn.crypt.byteenc = newcclosure(function(data)
    local ByteString = ""
    data:gsub(".", function(Character)
        ByteString = ByteString.."\\"..string.byte(Character)
    end)

    return ByteString
end)
nrn.crypt.byteencode = nrn.crypt.byteenc

nrn.crypt.bytedec = newcclosure(function(data)
    return data:sub(1, string.len(data))
end)
nrn.crypt.bytedecode = nrn.crypt.bytedec

nrn.getfingerprint = newcclosure(function()
    local Status = MakeWebsocketRequest("/wrapper/fingerprint", {}, {})
    return Status
end)

nrn.gethwid = newcclosure(function()
    local Status = MakeWebsocketRequest("/wrapper/hwid", {}, {})
    return Status
end)

getgenv().messagebox = newcclosure(function(title, message)
    title = title or ""
    message = message or ""
    if type(title) ~= "string" then
        error("Expected a string as argument 1.", 0)
    elseif type(message) ~= "string" then
        error("Expected a string as argument 2.", 0)
    end

    local Status = MakeWebsocketRequest(
        "/wrapper/msgbox", 
        {"title", "message"}, 
        {title, message}
    )

    return true
end)
getgenv().msgbox = messagebox

getgenv().isrbxactive = isRobloxFocused -- lolwut
-- Remove useless functions.
getgenv()._require = nil
getgenv().OpenWebsite = nil -- security flaw so def removing

-- Declare our finish!
game:GetService("StarterGui"):SetCore("ChatMakeSystemMessage", {
    Text = "Neuron has sucessfullly attached!",
    Color = Color3.fromRGB(0, 243, 0),
    TextSize = 19.5
})
