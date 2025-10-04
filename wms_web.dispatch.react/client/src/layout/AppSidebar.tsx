import React, { useCallback, useEffect, useRef, useState } from "react";
import { Link, useLocation } from "react-router-dom";
import { 
  LayoutDashboard, 
  Package, 
  Truck, 
  PlusCircle, 
  BarChart3, 
  Users, 
  Settings,
  LogOut,
  ChevronDown,
  Menu,
  ShieldCheck,
  Building2,
  FileText
} from "lucide-react";
import { useSidebar } from "../context/SidebarContext";
import { useAuth } from "../context/AuthContext";
import clsx from "clsx";

type NavItem = {
  name: string;
  icon: React.ReactNode;
  path?: string;
  subItems?: { name: string; path: string; roles?: string[] }[];
  roles?: string[];
};

const AppSidebar: React.FC = () => {
  const { isExpanded, isMobileOpen, isHovered, setIsHovered, setIsMobileOpen, setIsExpanded } = useSidebar();
  const { user, logout } = useAuth();
  const location = useLocation();

  const [openSubmenu, setOpenSubmenu] = useState<string | null>(null);
  const [subMenuHeight, setSubMenuHeight] = useState<Record<string, number>>({});
  const [manuallyOpened, setManuallyOpened] = useState<string | null>(null); // Track manually opened submenus
  const subMenuRefs = useRef<Record<string, HTMLDivElement | null>>({});

  const navItems: NavItem[] = [
    {
      icon: <LayoutDashboard className="w-6 h-6" />,
      name: "Dashboard",
      path: "/dashboard",
    },
    {
      icon: <Package className="w-6 h-6" />,
      name: "Parcels",
      path: "/parcels",
    },
    {
      icon: <Truck className="w-6 h-6" />,
      name: "Dispatches",
      subItems: [
        { name: "View Dispatches", path: "/dispatches/view" },
        { name: "Create Dispatch", path: "/dispatches/create", roles: ['branch_manager', 'admin'] }
      ],
    },
    {
      icon: <BarChart3 className="w-6 h-6" />,
      name: "Reports",
      path: "/reports",
      roles: ['branch_manager', 'admin'],
    },
    {
      icon: <Building2 className="w-6 h-6" />,
      name: "Contract Customers",
      path: "/contract-customers",
      roles: ['branch_manager', 'admin'],
    },
    {
      icon: <FileText className="w-6 h-6" />,
      name: "Invoices",
      path: "/invoices",
      roles: ['branch_manager', 'admin'],
    },
    {
      icon: <Users className="w-6 h-6" />,
      name: "User Management", 
      path: "/user-management",
      roles: ['admin'],
    },
    {
      icon: <ShieldCheck className="w-6 h-6" />,
      name: "Manage Parcels", 
      path: "/admin/parcels",
      roles: ['admin'],
    },
    {
      icon: <Settings className="w-6 h-6" />,
      name: "Settings",
      path: "/settings",
    },
  ];

  const isActive = useCallback(
    (path: string) => location.pathname === path,
    [location.pathname]
  );

  const hasPermission = useCallback(
    (roles?: string[]) => {
      if (!roles || roles.length === 0) return true;
      return user && roles.includes(user.role);
    },
    [user]
  );

  useEffect(() => {
    let submenuMatched = false;
    navItems.forEach((nav) => {
      if (nav.subItems) {
        nav.subItems.forEach((subItem) => {
          if (isActive(subItem.path)) {
            setOpenSubmenu(nav.name);
            submenuMatched = true;
          }
        });
      }
    });

    // Only close submenu if we're navigating to a route that should close it
    // Don't auto-close manually opened submenus
    if (!submenuMatched && !manuallyOpened) {
      setOpenSubmenu(null);
    }
  }, [location, isActive, navItems]);

  useEffect(() => {
    if (openSubmenu !== null) {
      const key = openSubmenu;
      
      // Use requestAnimationFrame to ensure DOM is rendered
      requestAnimationFrame(() => {
        if (subMenuRefs.current[key]) {
          const element = subMenuRefs.current[key];
          const scrollHeight = element?.scrollHeight || 0;
          setSubMenuHeight((prevHeights) => ({
            ...prevHeights,
            [key]: Math.max(scrollHeight, 80), // Fallback to 80px minimum
          }));
        }
      });
    } else {
      // Reset all heights when no submenu is open
      setSubMenuHeight({});
    }
  }, [openSubmenu]);

  const handleSubmenuToggle = (itemName: string) => {
    // If sidebar is collapsed on desktop, expand it first
    if (!isExpanded && !isMobileOpen && window.innerWidth >= 1024) {
      setIsExpanded(true);
    }
    
    setOpenSubmenu((prevOpenSubmenu) => {
      const newState = prevOpenSubmenu === itemName ? null : itemName;
      
      // Track manually opened submenus
      setManuallyOpened(newState);
      
      return newState;
    });
  };

  const handleLogout = () => {
    logout();
  };

  // Close mobile sidebar when navigating to a new page (disabled for debugging)
  // const prevPathRef = useRef(location.pathname);
  // useEffect(() => {
  //   if (prevPathRef.current !== location.pathname && isMobileOpen) {
  //     setIsMobileOpen(false);
  //   }
  //   prevPathRef.current = location.pathname;
  // }, [location.pathname, isMobileOpen, setIsMobileOpen]);

  if (!user) return null;

  return (
    <aside
      className={clsx(
        "fixed top-0 left-0 z-40 h-screen bg-white dark:bg-gray-900 border-r border-gray-200 dark:border-gray-800 transition-all duration-300 ease-in-out",
        {
          // Mobile: Always full width when open
          "w-64": isMobileOpen,
          // Desktop: Full width when expanded OR (collapsed but hovered)
          "lg:w-64": isExpanded || (isHovered && !isExpanded),
          "lg:w-20": !isExpanded && !isHovered,
          "translate-x-0": isMobileOpen,
          "-translate-x-full lg:translate-x-0": !isMobileOpen,
        }
      )}
      onMouseEnter={() => !isExpanded && window.innerWidth >= 1024 && setIsHovered(true)}
      onMouseLeave={() => setIsHovered(false)}
    >
      {/* Brand Header */}
      <div className="flex items-center justify-center p-6 border-b border-gray-200 dark:border-gray-800">
        <Link to="/dashboard" className="flex items-center space-x-3">
          {isExpanded || isHovered || isMobileOpen ? (
            <>
              <div className="w-10 h-10 bg-brand-500 rounded-xl flex items-center justify-center shadow-lg">
                <Package className="w-6 h-6 text-white" />
              </div>
              <div className="flex flex-col">
                <span className="text-xl font-bold text-gray-900 dark:text-white">
                  WMS Dispatch
                </span>
                <span className="text-xs text-gray-500 dark:text-gray-400">
                  Warehouse Management
                </span>
              </div>
            </>
          ) : (
            <div className="w-10 h-10 bg-brand-500 rounded-xl flex items-center justify-center shadow-lg">
              <Package className="w-6 h-6 text-white" />
            </div>
          )}
        </Link>
      </div>

      {/* User Info */}
      {(isExpanded || isHovered || isMobileOpen) && (
        <div className="p-4 border-b border-gray-200 dark:border-gray-800 bg-gray-50 dark:bg-gray-800/50">
          <div className="flex items-center space-x-3">
            <div className="w-12 h-12 bg-gradient-to-br from-brand-400 to-brand-600 rounded-xl flex items-center justify-center shadow-md">
              <span className="text-white font-bold text-base">
                {user.username.charAt(0).toUpperCase()}
              </span>
            </div>
            <div className="flex-1 min-w-0">
              <p className="text-sm font-semibold text-gray-900 dark:text-white truncate">
                {user.username}
              </p>
              <p className="text-xs text-gray-500 dark:text-gray-400 truncate capitalize">
                {user.role?.replace('_', ' ')}
              </p>
              {user.branch && (
                <p className="text-xs text-brand-600 dark:text-brand-400 truncate">
                  {user.branch}
                </p>
              )}
            </div>
          </div>
        </div>
      )}

      {/* Navigation */}
      <nav className="flex-1 px-4 py-6 space-y-1 overflow-y-auto custom-scrollbar">
        {/* Navigation Section Header */}
        {(isExpanded || isHovered || isMobileOpen) && (
          <div className="px-3 mb-4">
            <h2 className="text-xs font-semibold text-gray-400 uppercase tracking-wide">
              Menu
            </h2>
          </div>
        )}
        
        {navItems.map((nav) => {
          if (!hasPermission(nav.roles)) return null;

          return (
            <div key={nav.name}>
              {nav.subItems ? (
                <button
                  onClick={(e) => {
                    e.preventDefault();
                    e.stopPropagation();
                    handleSubmenuToggle(nav.name);
                  }}
                  className={clsx(
                    "menu-item group w-full text-left",
                    {
                      "menu-item-active": openSubmenu === nav.name,
                      "menu-item-inactive": openSubmenu !== nav.name,
                      "justify-center": !isExpanded && !isHovered && !isMobileOpen,
                      "justify-start": isExpanded || isHovered || isMobileOpen,
                    }
                  )}
                >
                  <span
                    className={clsx("flex-shrink-0", {
                      "menu-item-icon-active": openSubmenu === nav.name,
                      "menu-item-icon-inactive": openSubmenu !== nav.name,
                    })}
                  >
                    {nav.icon}
                  </span>
                  {(isExpanded || isHovered || isMobileOpen) && (
                    <>
                      <span className="flex-1">{nav.name}</span>
                      <ChevronDown
                        className={clsx(
                          "w-4 h-4 transition-transform duration-200",
                          {
                            "rotate-180": openSubmenu === nav.name,
                            "text-brand-500": openSubmenu === nav.name,
                          }
                        )}
                      />
                    </>
                  )}
                </button>
              ) : (
                nav.path && (
                  <Link
                    to={nav.path}
                    className={clsx(
                      "menu-item group",
                      {
                        "menu-item-active": isActive(nav.path),
                        "menu-item-inactive": !isActive(nav.path),
                        "justify-center": !isExpanded && !isHovered && !isMobileOpen,
                        "justify-start": isExpanded || isHovered || isMobileOpen,
                      }
                    )}
                  >
                    <span
                      className={clsx("flex-shrink-0", {
                        "menu-item-icon-active": isActive(nav.path),
                        "menu-item-icon-inactive": !isActive(nav.path),
                      })}
                    >
                      {nav.icon}
                    </span>
                    {(isExpanded || isHovered || isMobileOpen) && (
                      <span>{nav.name}</span>
                    )}
                  </Link>
                )
              )}

              {/* Submenu */}
              {nav.subItems && (isExpanded || isHovered || isMobileOpen || openSubmenu === nav.name) && (
                <div
                  ref={(el) => {
                    subMenuRefs.current[nav.name] = el;
                  }}
                  className="overflow-hidden transition-all duration-300"
                  style={{
                    height:
                      openSubmenu === nav.name
                        ? `${subMenuHeight[nav.name] || 0}px`
                        : "0px",
                  }}
                >
                  <div className="mt-2 space-y-1 ml-9">
                    {nav.subItems.map((subItem) => {
                      if (!hasPermission(subItem.roles)) return null;
                      
                      return (
                        <Link
                          key={subItem.name}
                          to={subItem.path}
                          className={clsx(
                            "menu-dropdown-item",
                            {
                              "menu-dropdown-item-active": isActive(subItem.path),
                              "menu-dropdown-item-inactive": !isActive(subItem.path),
                            }
                          )}
                        >
                          {subItem.name}
                        </Link>
                      );
                    })}
                  </div>
                </div>
              )}
            </div>
          );
        })}
      </nav>

      {/* Logout Button */}
      <div className="p-4 border-t border-gray-200 dark:border-gray-800 bg-gray-50 dark:bg-gray-800/30">
        <button
          onClick={handleLogout}
          className={clsx(
            "menu-item group w-full text-left text-error-600 hover:bg-error-50 hover:text-error-700 dark:text-error-400 dark:hover:bg-error-500/10 dark:hover:text-error-300",
            {
              "justify-center": !isExpanded && !isHovered && !isMobileOpen,
              "justify-start": isExpanded || isHovered || isMobileOpen,
            }
          )}
        >
          <LogOut className="w-5 h-5 flex-shrink-0" />
          {(isExpanded || isHovered || isMobileOpen) && (
            <span className="font-medium">Logout</span>
          )}
        </button>
      </div>
    </aside>
  );
};

export default AppSidebar;