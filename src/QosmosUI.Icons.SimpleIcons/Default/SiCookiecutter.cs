// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiCookiecutter : ComponentBase
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
		builder.AddAttribute(15, "d", "M12.806 0a12 12 0 0 0-4.512.885A12 12 0 0 0 .858 12.978a12 12 0 0 0 9.303 10.724 12 12 0 0 0 13.021-5.656L12.817 12l9.244-7.65A12 12 0 0 0 12.806 0zM9.218 2.143c.34-.003.701.123 1.193.378.847.437 1.013 1.027.36 1.277-.487.187-2.457.177-2.932-.015-.526-.212-.38-.781.32-1.24.402-.263.72-.396 1.059-.4zm4.077 4.052a1.292 1.292 0 0 1 .022 0 1.292 1.292 0 0 1 1.292 1.291 1.292 1.292 0 0 1-1.292 1.292 1.292 1.292 0 0 1-1.292-1.292 1.292 1.292 0 0 1 1.27-1.291zm-6.259 3.8c1.033 0 1.788.434 1.788 1.028 0 .694-1.961 2.384-2.766 2.384-.365 0-.727-.166-.804-.368-.078-.203.117-.97.434-1.706.505-1.176.67-1.338 1.348-1.338zm8.637 9.187c.372 0 1.362 2.316 1.186 2.775-.201.524-1.046.467-1.564-.105-.676-.747-.404-2.67.378-2.67z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
