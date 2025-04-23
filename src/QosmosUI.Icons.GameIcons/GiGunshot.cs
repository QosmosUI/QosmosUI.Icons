// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiGunshot : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 512 512";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M33.385 18.482l179.818 179.82c15.992-12.5 32.854-21.332 49.008-25.884 6.11-1.722 12.21-2.827 18.142-3.232L129.646 18.482h-96.26zM18.1 94.508v22.414l143.933 143.933c2.284-4.853 4.898-9.714 7.87-14.544L18.1 94.51zm0 48.844v21.718l133.513 133.514c.357-6.05 1.454-12.282 3.192-18.527L18.1 143.352zm267.76 44.308c-5.534-.06-11.76.824-18.58 2.746-18.187 5.125-39.366 17.645-58.06 36.338-18.693 18.693-31.214 39.874-36.34 58.06-5.124 18.187-2.865 32.154 4.983 40.003 7.848 7.848 21.816 10.107 40.002 4.982 2.79-.787 5.657-1.767 8.57-2.897-4.446 35.305 2.834 81.353 22.27 137.377 7.042-107.06 40.21-77.135 84.346 18.867-25.618-105.636 50.953-72.313 151.733 8.195-82.658-96.046-104.87-162.764 10.524-134.658-113.18-40.95-130.87-81.878-33.092-84.97-63.505-23.373-114.68-32.166-153.004-27.345 1.2-3.05 2.23-6.05 3.054-8.97 5.124-18.186 2.867-32.155-4.98-40.003-4.906-4.905-12.203-7.627-21.425-7.727zm-15.63 20.928c7.007.084 13.038 2.182 17.358 6.502 7.242 7.242 8.227 19.295 3.96 32.7-32.244 8.713-52.945 29.435-61.653 61.358-13.234 4.11-25.11 3.073-32.274-4.09-13.822-13.824-4.888-45.17 19.956-70.013 17.08-17.08 37.233-26.642 52.653-26.457z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
