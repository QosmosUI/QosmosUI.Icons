// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiFueler : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0c1.204 0 2.086 1.932 3.172 2.283 1.126.364 2.978-.67 3.915.009.946.685.527 2.762 1.216 3.704.682.933 2.8 1.175 3.165 2.295.353 1.081-1.207 2.51-1.207 3.709 0 1.198 1.56 2.628 1.207 3.709-.365 1.12-2.483 1.362-3.165 2.295-.69.942-.27 3.02-1.217 3.704-.937.68-2.789-.355-3.914.01C14.086 22.067 13.204 24 12 24c-1.204 0-2.086-1.932-3.172-2.283-1.126-.364-2.978.67-3.915-.009-.946-.685-.527-2.762-1.216-3.704-.682-.933-2.8-1.175-3.165-2.295-.353-1.081 1.207-2.51 1.207-3.709 0-1.198-1.56-2.628-1.207-3.709.365-1.12 2.483-1.362 3.166-2.295.688-.942.27-3.02 1.216-3.704.937-.68 2.789.355 3.914-.01C9.914 1.933 10.796 0 12 0Zm-.199 6.34-3.247 6.169c-.158.3.065.653.388.654h1.707c.234 0 .44.193.44.445v3.706c0 .459.603.618.825.218l3.39-6.11c.16-.289-.043-.662-.384-.663l-1.85-.002c-.243 0-.44-.2-.44-.445V6.549c0-.464-.613-.619-.829-.21Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
