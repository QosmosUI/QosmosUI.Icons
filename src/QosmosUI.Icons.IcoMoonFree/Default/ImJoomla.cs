// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImJoomla : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M4.156 4.323c0.513-0.513 1.344-0.513 1.856-0l0.122 0.123 1.58-1.581-0.123-0.123c-0.9-0.902-2.164-1.217-3.319-0.946-0.166-1.018-1.048-1.796-2.112-1.796-1.182 0-2.14 0.96-2.14 2.143 0 1.021 0.712 1.875 1.667 2.091-0.362 1.21-0.066 2.576 0.888 3.531l3.56 3.561 1.578-1.581-3.56-3.561c-0.511-0.511-0.512-1.346 0.003-1.861zM15.98 2.143c0-1.184-0.958-2.143-2.14-2.143-1.082 0-1.976 0.804-2.12 1.847-1.204-0.354-2.559-0.055-3.51 0.897l-3.56 3.561 1.58 1.581 3.559-3.56c0.515-0.515 1.344-0.514 1.854-0.003 0.512 0.513 0.512 1.346-0.001 1.859l-0.122 0.122 1.578 1.582 0.123-0.124c0.945-0.946 1.245-2.293 0.9-3.494 1.049-0.138 1.858-1.037 1.858-2.125zM14.16 11.735c0.283-1.163-0.031-2.443-0.939-3.352l-3.555-3.562-1.58 1.58 3.555 3.563c0.515 0.516 0.514 1.345 0.003 1.857-0.513 0.513-1.344 0.513-1.857-0l-0.121-0.122-1.578 1.582 0.121 0.121c0.961 0.962 2.338 1.257 3.553 0.883 0.197 0.979 1.061 1.716 2.098 1.716 1.181 0 2.14-0.959 2.14-2.143 0-1.081-0.8-1.976-1.84-2.122zM9.568 8.261l-3.555 3.562c-0.511 0.512-1.344 0.513-1.859-0.002-0.513-0.514-0.513-1.345-0.001-1.859l0.122-0.121-1.579-1.58-0.121 0.12c-0.918 0.919-1.228 2.216-0.929 3.39-0.944 0.223-1.646 1.072-1.646 2.086-0 1.184 0.958 2.143 2.14 2.143 1.017-0.001 1.869-0.71 2.087-1.662 1.167 0.29 2.453-0.020 3.365-0.934l3.555-3.562-1.578-1.582z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
