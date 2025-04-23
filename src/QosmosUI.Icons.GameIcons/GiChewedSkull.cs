// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiChewedSkull : ComponentBase
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
		builder.AddAttribute(14, "d", "M262.81 16.098c-10.335-.044-20.657.6-30.867 1.894l-2.68.246c1.754 19.05-1.177 32.7-7.144 39.69-5.967 6.99-15.964 10.454-36.102 6.328l-18.686-3.83 8.426 17.11c5.744 11.666 2.894 24.13-5.42 31.386s-22.805 10.594-44.797-1.443l-17.257-9.447 3.582 19.344c3.326 17.958-1.815 26.41-10.158 31.99-8.343 5.582-21.628 7.223-33.15 4.725l-.14.644-2.292-1.51c-8.416 30.07-10.557 65.306-4.252 106.08l15.184 94.135 70.295-13.24 3.46 18.366-15.384 2.897L179.96 488.79h25.39l-7.81-61.89 18.534-2.337 8.104 64.226h29.613v-65.325h18.69v65.324h29.61l8.105-64.228 18.534 2.338-7.81 61.89h25.486l44.352-126.808-18.133-3.416 3.46-18.365 70.185 13.22 18.236-94.22c12.634-81.883-9.59-141.71-48.71-181.966-39.135-40.268-95.95-60.884-152.966-61.136h-.02zm-14.51 20.14c45.57 29.486 39.706 97.78-19.587 70.834 34.772 67.943-24.572 97.148-69.838 55.2 3.894 37.6-40.093 48.023-69.316 11.056 7.962-1.166 15.703-3.855 22.538-8.428 10.563-7.066 17.958-19.23 19.1-34.785 20.852 6.868 39.385 3.4 51.43-7.113 10.958-9.566 16.144-24.103 14.368-38.635 16.913.726 30.568-4.03 39.34-14.306 7.624-8.933 11.127-20.532 11.965-33.822zm-61.9 167.98c32.884 0 59.54 26.656 59.54 59.54 0 32.885-26.656 59.543-59.54 59.543-32.883 0-59.543-26.657-59.543-59.542 0-32.886 26.66-59.54 59.543-59.54zm157.543 0c32.884 0 59.54 26.656 59.54 59.54 0 32.885-26.656 59.543-59.54 59.543-32.883 0-59.543-26.657-59.543-59.542 0-32.886 26.66-59.54 59.543-59.54zm-80.675 79.74l39.937 101.6-17.03 7.05-22.905-35.477-22.905 35.477-17.62-7.048 40.523-101.603z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
