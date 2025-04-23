// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiSmashingmagazine : ComponentBase
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
		builder.AddAttribute(15, "d", "M7.734 12.002c.766.524 1.662 1.01 2.708 1.443 1.785.742 2.985 1.387 3.601 1.936.615.547.928 1.248.928 2.104-.005 1.457-1.023 2.189-3.076 2.189-1.977 0-3.75-.627-5.326-1.875l-1.871 4.186c1.422.761 2.58 1.257 3.475 1.496l.141.033-1.798.416c-1.271.292-2.539-.503-2.832-1.771L.061 6.5c-.291-1.271.5-2.539 1.773-2.835l4.375-1.009c-.158.155-.307.316-.441.485l-.018.021c-.753.949-1.131 2.115-1.131 3.505 0 2.101 1.03 3.87 3.079 5.296l.046.029-.01.01zm10.358.072c-.84-.672-1.904-1.268-3.24-1.786-1.98-.784-3.271-1.41-3.871-1.872-.6-.465-.914-.981-.914-1.557 0-1.459.914-2.19 2.76-2.19 2.041 0 3.646.494 4.786 1.476l1.515-4.08c-1.095-.556-2.235-.96-3.405-1.216l-.06-.015c-.256-.061-.525-.12-.811-.164l2.625-.602c1.275-.285 2.535.511 2.836 1.771l3.63 15.647c.284 1.274-.51 2.551-1.784 2.835l-2.985.69c.824-1.051 1.245-2.34 1.245-3.87 0-1.575-.437-2.911-1.306-4.021-.285-.346-.615-.676-1.006-1.006l-.044-.029.029-.011z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
