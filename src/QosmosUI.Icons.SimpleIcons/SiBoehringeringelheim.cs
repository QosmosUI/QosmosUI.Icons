// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiBoehringeringelheim : ComponentBase
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
		builder.AddAttribute(15, "d", "M5.41 22.03c-1.72-1.24-2.63-2.15-3.49-3.46A12.185 12.185 0 0 1 0 12.03C0 5.38 5.36 0 12 0s12 5.38 12 12c0 2.73-.93 5.46-2.58 7.48-.68.86-1.26 1.36-2.83 2.55v-7.02h1.19v4.8c.88-1.04 1.31-1.67 1.74-2.43.88-1.57 1.36-3.51 1.36-5.38 0-6.06-4.88-10.99-10.89-10.99S1.11 5.94 1.11 12.08c0 2.8.99 5.28 3.08 7.73v-4.8H5.4v7.02Zm2.37 1.21c-.23-.05-.76-.3-1.19-.53V15h1.19v8.24Zm7.23-16.92L12 4 8.99 6.32l-.66-.86 3.66-2.86 3.66 2.86-.66.86Zm-4.83 17.56c-.43-.08-.45-.08-.61-.13-.13-.02-.18-.02-.58-.13V7.2h1.19v16.67Zm2.4.1c-.18.02-.23.02-.48.02-.38 0-.51 0-.71-.02V7.2h1.19v16.78Zm2.4-.38c-.38.13-.71.2-1.19.3V7.2h1.19v16.4Zm2.43-.88c-.38.18-.61.28-1.21.56v-8.27h1.21v7.71Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
