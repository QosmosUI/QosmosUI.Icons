// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiGnome : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M19.703 0c-4.99 0-5.927 7.111-3.12 7.111 2.81 0 8.113-7.111 3.12-7.111M11.99.872q-.119-.001-.25.016c-2.811.364-1.82 5.25-.324 5.34 1.449.09 3.032-5.347.574-5.356M7.123 2.803a1.4 1.4 0 0 0-.488.114c-2.259.933-.344 4.776.921 4.519 1.168-.24 1.319-4.671-.433-4.632Zm-3.6 3.016a1.05 1.05 0 0 0-.634.215c-1.807 1.248.607 4.269 1.671 3.799.93-.41.338-3.967-1.037-4.014m10.032 2.309c-3.835.033-8.716 1.978-9.567 5.784C3.044 18.14 7.875 24 12.915 24c2.48 0 5.34-2.24 5.875-5.077.409-2.163-4.81-1.295-4.623.137.225 1.715-1.258 2.561-2.711 1.454-4.623-3.52 7.658-5.276 6.847-10.086-.263-1.56-2.29-2.322-4.748-2.301Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
