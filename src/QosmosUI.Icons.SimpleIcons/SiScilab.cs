// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiScilab : ComponentBase
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
		builder.AddAttribute(15, "d", "M3.813 1.803c-1.103 0-1.99.888-1.99 1.99v16.414c0 1.102.887 1.99 1.99 1.99h16.375c1.102 0 1.99-.888 1.99-1.99V3.793c0-1.102-.888-1.99-1.99-1.99zm8.82 1.234a1.802 1.825 0 0 1 1.803 1.824 1.802 1.825 0 0 1-1.803 1.827A1.802 1.825 0 0 1 10.83 4.86a1.802 1.825 0 0 1 1.803-1.824Zm2.986 3.496a1.802 1.825 0 0 1 1.803 1.826 1.802 1.825 0 0 1-1.803 1.825 1.802 1.825 0 0 1-1.803-1.825 1.802 1.825 0 0 1 1.803-1.826Zm-7.346.26a1.802 1.825 0 0 1 1.803 1.824 1.802 1.825 0 0 1-1.803 1.826 1.802 1.825 0 0 1-1.802-1.826 1.802 1.825 0 0 1 1.802-1.824Zm3.98 2.633a1.802 1.825 0 0 1 1.804 1.826 1.802 1.825 0 0 1-1.803 1.824 1.802 1.825 0 0 1-1.803-1.824 1.802 1.825 0 0 1 1.803-1.826zm7.044.053a1.802 1.825 0 0 1 1.803 1.826 1.802 1.825 0 0 1-1.803 1.824 1.802 1.825 0 0 1-1.8-1.824 1.802 1.825 0 0 1 1.8-1.826zm-3.402 2.535a1.802 1.825 0 0 1 1.802 1.826 1.802 1.825 0 0 1-1.802 1.824 1.802 1.825 0 0 1-1.803-1.824 1.802 1.825 0 0 1 1.803-1.826zm-11.614.953a1.802 1.825 0 0 1 1.803 1.826 1.802 1.825 0 0 1-1.803 1.824 1.802 1.825 0 0 1-1.802-1.824 1.802 1.825 0 0 1 1.802-1.826Zm15.518.93a1.802 1.825 0 0 1 1.803 1.824 1.802 1.825 0 0 1-1.803 1.826 1.802 1.825 0 0 1-1.803-1.826 1.802 1.825 0 0 1 1.803-1.825zM7.81 15.665a1.802 1.825 0 0 1 1.802 1.824 1.802 1.825 0 0 1-1.802 1.826 1.802 1.825 0 0 1-1.803-1.826 1.802 1.825 0 0 1 1.803-1.824ZM3.564 0A3.556 3.556 0 0 0 0 3.564v16.872A3.556 3.556 0 0 0 3.564 24h16.872A3.556 3.556 0 0 0 24 20.436V3.564A3.556 3.556 0 0 0 20.436 0Zm-.002 1.021h16.875a2.536 2.536 0 0 1 2.542 2.542v16.875a2.536 2.536 0 0 1-2.542 2.54H3.563a2.536 2.536 0 0 1-2.54-2.54V3.563a2.536 2.536 0 0 1 2.54-2.542z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
