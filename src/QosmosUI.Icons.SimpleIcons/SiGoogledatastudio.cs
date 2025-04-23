// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiGoogledatastudio : ComponentBase
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
		builder.AddAttribute(15, "d", "M19.197 23.002c-1.016-.613-1.697-1.728-1.697-3 0-1.273.681-2.388 1.697-3h-6.909a3.034 3.034 0 0 0-.252-.011c-1.656 0-3.022 1.355-3.036 3.011v.014c0 1.645 1.354 3 3 3 .096 0 .192-.005.288-.014h6.909Zm1.803-6c1.656 0 3 1.344 3 3s-1.344 3-3 3-3-1.344-3-3 1.344-3 3-3Zm-10.803-2.004c-1.016-.613-1.697-1.728-1.697-3 0-1.273.681-2.388 1.697-3H3.288a3.034 3.034 0 0 0-.252-.011C1.38 8.987.014 10.342 0 11.998v.014c0 1.645 1.354 3 3 3 .096 0 .192-.005.288-.014h6.909Zm1.803-6c1.656 0 3 1.344 3 3s-1.344 3-3 3-3-1.344-3-3 1.344-3 3-3Zm7.197-2.004c-1.016-.613-1.697-1.728-1.697-3 0-1.273.681-2.388 1.697-3h-6.909c-.08-.006-.16-.01-.24-.01C10.39.984 9.021 2.336 9 3.994v.014c0 1.645 1.354 3 3 3 .096 0 .192-.005.288-.014h6.909Zm1.803-6c1.656 0 3 1.344 3 3s-1.344 3-3 3-3-1.344-3-3 1.344-3 3-3Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
